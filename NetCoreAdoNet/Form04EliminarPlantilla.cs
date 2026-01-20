using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace NetCoreAdoNet
{
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadPlantilla();
        }

        private void LoadPlantilla()
        {
            string sql = "select * from PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string empleado_no = this.reader["EMPLEADO_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                string hospital_COD = this.reader["HOSPITAL_COD"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                this.lstPlantilla.Items.Add(empleado_no + " - " + apellido + ", Hospital: " + hospital_COD + ", Funcion: "+funcion);
            }
            this.reader.Close();
            this.cn.Close();
        }

      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string empleado_no = this.txtEmpleado_no.Text;
            string sql = "delete from PLANTILLA where EMPLEADO_NO=" + empleado_no;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.LoadPlantilla();
            MessageBox.Show("Empleados eliminados: " + registros);
        }
    }
}
