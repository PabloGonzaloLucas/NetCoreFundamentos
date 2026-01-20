using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=Hospital;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "select distinct DNOMBRE from DEPARTAMENTOS";
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            if (this.connection.State == ConnectionState.Closed)
            {
                await this.connection.OpenAsync();
            }
            this.reader = await this.command.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            this.reader.Close();
            this.connection.Close();
            return departamentos;
        } 
        public async Task<List<string>> GetEmpleadosDepartamentosAsync(string departamento)
        {
            string sql = "select APELLIDO from EMP join DEPT on EMP.DEPT_NO = DEPT.DEPT_NO " +
                "where DEPT.DNOMBRE = @departamento";
            SqlParameter paramDept = new SqlParameter("@departamento", departamento);
            this.command.Parameters.Add(paramDept);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            await this.connection.OpenAsync();
            this.reader = await this.command.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                apellidos.Add(apellido);
            }
            this.reader.Close();
            this.command.Parameters.Clear();
            this.connection.Close();
            return apellidos;
        }

        public async Task<int> DeleteEmpleadoAsync(string apellido)
        {
            string sql = "delete from EMP where APELLIDO = @apellido";
            SqlParameter paramApellido = new SqlParameter("@apellido", apellido);
            this.command.Parameters.Add(paramApellido);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            await this.connection.OpenAsync();
            int registros = await this.command.ExecuteNonQueryAsync();
            this.command.Parameters.Clear();
            this.connection.Close();
            return registros;
        }

    }


}
