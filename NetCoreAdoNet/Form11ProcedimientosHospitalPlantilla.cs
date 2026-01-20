using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS 
//create procedure SP_ALL_HOSPITALES
//as 
//    select * from HOSPITAL
//go

//create procedure SP_UPDATE_PLANTILLA_HOSPITAL
//(@nombre as NVARCHAR(50), @incremento int)
//as
//    declare @hospitalcod int select @hospitalcod = HOSPITAL_COD from Hospital where NOMBRE = @nombre
//    update PLANTILLA set SALARIO = SALARIO + @incremento 
//    where HOSPITAL_COD = @hospitalcod
//go

//create procedure SP_PLANTILLA_HOSPITAL
//(@nombre varchar(50))
//as 
//    select PLANTILLA.* from PLANTILLA
//    inner join HOSPITAL
//    on HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
//    where HOSPITAL.NOMBRE = @nombre
//go


#endregion

namespace NetCoreAdoNet
{
    public partial class Form11ProcedimientosHospitalPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form11ProcedimientosHospitalPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True"; ;
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbHospitales.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private async void btnModificarSalarios_Click(object sender, EventArgs e)
        {
            string sql = "SP_UPDATE_PLANTILLA_HOSPITAL";
            if(txtIncremento.Text == "")
            {
                MessageBox.Show("escribe algo");
                return;
            }
            string nombreHospital = this.cmbHospitales.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            this.com.Parameters.AddWithValue("@nombre", nombreHospital);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            this.cn.Close();
            this.com.Parameters.Clear();
            await this.LoadPlantillaHospital(nombreHospital);
            MessageBox.Show("Registros modificados: " + registros);
        }

        private async Task LoadPlantillaHospital(string nombreHospital)
        {
            string sql = "SP_PLANTILLA_HOSPITAL";
            this.com.Parameters.AddWithValue("@nombre", nombreHospital);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(salario + " - " + salario);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            await this.LoadPlantillaHospital(this.cmbHospitales.SelectedItem.ToString());
        }
    }
}
