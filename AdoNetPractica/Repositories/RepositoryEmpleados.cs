using AdoNetPractica.Helpers;
using AdoNetPractica.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#region procedures 
/*create procedure SP_NOMBRES_HOSPITALES 
as 
select NOMBRE from HOSPITAL;
go

create view V_ALL_PLANTILLA 
as 
  select HOSPITAL_COD as HOSPITAL_COD, EMPLEADO_NO AS EMP_NO, APELLIDO AS APELLIDO, FUNCION AS ESPECIALIDAD, SALARIO AS SALARIO
            from PLANTILLA
           UNION
          select HOSPITAL_COD, DOCTOR_NO, APELLIDO, ESPECIALIDAD, SALARIO 
            from DOCTOR
go

create procedure SP_EMPLEADOS_HOSPITAL
(@nombreHospital NVARCHAR(50), @sumaSalarial int out, @mediaSalarial int out, @personas int out)
as
    declare @idHospital int 
    select @idHospital = HOSPITAL.HOSPITAL_COD from HOSPITAL where NOMBRE = @nombreHospital
    select * from V_ALL_PLANTILLA
      where HOSPITAL_COD = @idHospital;

      select @sumaSalarial = ISNULL(sum(SALARIO),0), @mediaSalarial = ISNULL(AVG(SALARIO),0), @personas = COUNT(EMP_NO) from V_ALL_PLANTILLA
      where HOSPITAL_COD = @idHospital;
go 
*/
#endregion

namespace AdoNetPractica.Repositories
{
    public class RepositoryEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryEmpleados()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombresHospitalesAsync()
        {
            string sql = "SP_NOMBRES_HOSPITALES";
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> hospitales = new List<string>();
            while(await this.reader.ReadAsync())
            {
                hospitales.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
        
        public async Task<DatosPlantillaEmpleados> GetEmpleadosAsync(string nombreHospital)
        {
            string sql = "SP_EMPLEADOS_HOSPITAL";
            SqlParameter paramHospital = new SqlParameter();
            paramHospital.ParameterName = "@nombreHospital";
            paramHospital.Value = nombreHospital;
            this.com.Parameters.Add(paramHospital);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@sumaSalarial";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@mediaSalarial";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosPlantillaEmpleados plantilla = new DatosPlantillaEmpleados();
            plantilla.Empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {
                Empleado emp = new Empleado();
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.NumEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                emp.HospitalCod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                emp.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
                plantilla.Empleados.Add(emp);
            }
            this.reader.Close();
            plantilla.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            plantilla.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            plantilla.Personas = int.Parse(pamPersonas.Value.ToString());
            this.cn.Close();
            this.com.Parameters.Clear();
            //this.com.Parameters.AddWithValue("@nombre", nombre);
            return plantilla;
        }
    }
}
