using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region procedures
//create procedure SP_ALL_DEPARTAMENTOS
//as
//    select * from DEPARTAMENTOS
//go

//create procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre NVARCHAR(50), @localidad NVARCHAR(50))
//as
//    insert into DEPARTAMENTOS values(@numero, @nombre, @localidad)
//go
//alter procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre NVARCHAR(50), @localidad NVARCHAR(50))
//as
//    if(UPPER(@localidad) = 'TERUEL')
//    begin
//        print 'TERUEL NO EXISTE'
//    end
//    else
//    begin
//        insert into DEPARTAMENTOS values(@numero, @nombre, @localidad)
//    end
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True" ;
            this.cn = new SqlConnection(connectionString);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            Debug.WriteLine(e.Message);
            this.lblServidor.Text = e.Message.ToString();
            // MessageBox.Show(e.Message.ToString());
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while(await reader.ReadAsync())
            {
                Departamento dept = new Departamento();
                dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(dept.IdDepartamento + " - " + dept.Nombre + " - " + dept.Localidad);
            }
            this.cn.Close();
            this.reader.Close();
            
        }
        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lblServidor.Text = "";
            string sql = "SP_INSERT_DEPARTAMENTO";
            string nombre = this.txtNombre.Text.ToString();
            int numero = int.Parse(this.txtId.Text);
            string localidad = this.txtLocalidad.Text.ToString();
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            await this.cn.OpenAsync();
           // int registros = await this.com.ExecuteNonQueryAsync();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.LoadDepartamentos();
            MessageBox.Show("departamentos insertados: ", registros.ToString());
        }
    }
}
