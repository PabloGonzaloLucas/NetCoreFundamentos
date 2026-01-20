using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                Hospital hospital = new Hospital();
                hospital.Hospital_cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono= this.reader["TELEFONO"].ToString();
                hospital.Num_cama = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
        
        public async Task CreateHospitalAsync(int hospitalCod, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "insert into HOSPITAL values (@hospitalCod,@nombre,@direccion,@telefono,@numCamas)";
            this.com.Parameters.AddWithValue("@hospitalCod", hospitalCod);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@numCamas",  numCamas);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public async Task UpdateHospitalAsync(int hospitalCod, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "update HOSPITAL set NOMBRE = @nombre, DIRECCION = @direccion" +
                ", TELEFONO = @telefono, NUM_CAMA = @numCamas where HOSPITAL_COD = @hospitalCod";
            this.com.Parameters.AddWithValue("@hospitalCod", hospitalCod);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@numCamas", numCamas);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public async Task DeleteHospitalAsync(int hospitalCod)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD = @hospitalCod";
            this.com.Parameters.AddWithValue("@hospitalCod", hospitalCod);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            this.cn.Close();
            this.com.Parameters.Clear();
        }





    }
}
