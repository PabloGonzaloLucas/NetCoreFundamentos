using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlCommand com;
        private SqlConnection cn;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True"; ;
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficiosList = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficiosList.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
            return oficiosList;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "select APELLIDO from EMP where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                apellidos.Add(ape);
            }
            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();
            return apellidos;
        }

        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO = SALARIO + @incremento " +
                " where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            this.cn.Close();
            this.com.Parameters.Clear();
            return registros;
        }
        public async Task<int> GetDatosSalariosAsync(string oficio, string consulta)
        {
            string sql = "";
            if(consulta == "suma")
            {
               sql = "select SUM(SALARIO) as resul from EMP where OFICIO = @oficio";
            }
            else if(consulta == "media")
            {
               sql = "select AVG(SALARIO) as resul from EMP where OFICIO = @oficio";
            }
            else if(consulta == "maximo")
            {
               sql = "select MAX(SALARIO) as resul from EMP where OFICIO = @oficio";
            }
            else
            {
              // sql = "select MAX(SALARIO) as Maximo from EMP where OFICIO = @oficio";
            }
            this.com.Parameters.AddWithValue("oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            int resul = 0;
            while (await this.reader.ReadAsync())
            {
                resul = int.Parse(this.reader["resul"].ToString());
            }
            this.cn.Close();
            this.com.Parameters.Clear();
            return resul;
        }

        public async Task<DatosEmpleados> GetDatosSalariosAsyncV2(string oficio)
        {
            string sql = "select SUM(SALARIO) as SUMASALARIAL, AVG(SALARIO) AS MEDIA, MAX(SALARIO) AS MAXIMO from EMP where OFICIO = @oficio";
            this.com.Parameters.AddWithValue("oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleados data = new DatosEmpleados();
            await this.reader.ReadAsync();
            data.SumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            data.MediaSalarial = int.Parse(this.reader["MEDIA"].ToString());
            data.MaximoSalarial = int.Parse(this.reader["MAXIMO"].ToString());
            
            this.cn.Close();
            this.com.Parameters.Clear();
            return data;
        }


    }
}
