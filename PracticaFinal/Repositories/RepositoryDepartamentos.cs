using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PracticaFinal.Helpers;
using PracticaFinal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PracticaFinal.Repositories
{
    #region procedures
/*
 * exec SP_ALL_DEPARTAMENTOS
alter procedure SP_DATOS_DEPARTAMENTO 
(@nombreDepartamento nvarchar(50), @idDept int out, @localidad nvarchar(50) out )
as

select @idDept = DEPARTAMENTOS.DEPT_NO, @localidad = DEPARTAMENTOS.LOC 
  from DEPARTAMENTOS where DEPARTAMENTOS.DNOMBRE = @nombreDepartamento;

select * from EMP where EMP.DEPT_NO = @idDept;

go

declare @id int;
declare @nombre nvarchar(50);
declare @loc nvarchar(50);

exec SP_DATOS_DEPARTAMENTO 'INVESTIGACION', @id output, @loc output
print @id
print @nombre
print @loc

alter procedure SP_INSERT_DEPT
(@idDept int, @nombreDepartamento nvarchar(50), @localidad nvarchar(50))
as
insert into DEPARTAMENTOS values(@idDept, @nombreDepartamento, @localidad);
go

create procedure SP_GET_EMPLEADO_POR_APELLIDO
(@apellido nvarchar(50))
as
select emp.OFICIO, emp.SALARIO from EMP
where EMP.APELLIDO = @apellido;
go

create procedure SP_UPDATE_EMPLEADO
(@apellido nvarchar(50), @oficioNuevo nvarchar(50), @salarioNuevo int)
as
declare @idEmp int;
select @idEmp = emp.EMP_NO from EMP where EMP.APELLIDO = @apellido
update EMP set OFICIO = @oficioNuevo, SALARIO = @salarioNuevo 
where EMP_NO = @idEmp
go
*/
#endregion
public class RepositoryDepartamentos
{
    private SqlConnection cn;
    private SqlCommand com;
    private SqlDataReader reader;

    public RepositoryDepartamentos()
    {
        IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
        string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
        this.cn = new SqlConnection(connectionString);
        this.com = new SqlCommand();
        this.com.Connection = this.cn;
    }

    public async Task<List<Departamento>> GetDepartamentosAsync()
    {
        string sql = "SP_ALL_DEPARTAMENTOS";
        this.com.CommandType = System.Data.CommandType.StoredProcedure;
        this.com.CommandText = sql;
        await this.cn.OpenAsync();
        this.reader = await this.com.ExecuteReaderAsync();
        List<Departamento> departamentos = new List<Departamento>();
        while (await this.reader.ReadAsync())
        {
            Departamento dept = new Departamento();
            dept.Id = int.Parse(this.reader["DEPT_NO"].ToString());
            dept.Nombre = this.reader["DNOMBRE"].ToString();
            dept.Localidad = this.reader["LOC"].ToString();
            departamentos.Add(dept);
        }
        await this.reader.CloseAsync();
        await this.cn.CloseAsync();
        return departamentos;
    }

    public async Task<Departamento> GetDatosDepartamentoAsync(string nombreDept)
    {
        string sql = "SP_DATOS_DEPARTAMENTO";
        SqlParameter paramNombreDept = new SqlParameter();
        paramNombreDept.ParameterName = "@nombreDepartamento";
        paramNombreDept.Value = nombreDept;
        this.com.Parameters.Add(paramNombreDept);
        SqlParameter pamIdDept = new SqlParameter();
        pamIdDept.ParameterName = "@idDept";
        pamIdDept.Value = 0;
        pamIdDept.Direction = ParameterDirection.Output;
        this.com.Parameters.Add(pamIdDept);
        SqlParameter pamLocalidad = new SqlParameter("@localidad", SqlDbType.VarChar, 50);
        pamLocalidad.Direction = ParameterDirection.Output;
        this.com.Parameters.Add(pamLocalidad);

        this.com.CommandType = System.Data.CommandType.StoredProcedure;
        this.com.CommandText = sql;
        await this.cn.OpenAsync();
        this.reader = await this.com.ExecuteReaderAsync();
        Departamento dept = new Departamento();
        dept.Empleados = new List<Empleado>();
        while (await this.reader.ReadAsync())
        {
            Empleado emp = new Empleado();
            emp.Apellido = this.reader["APELLIDO"].ToString();
            emp.NumEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
            emp.NumDept = int.Parse(this.reader["DEPT_NO"].ToString());
            emp.Oficio = this.reader["OFICIO"].ToString();
            emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
            dept.Empleados.Add(emp);
        }
        await this.reader.CloseAsync();
        dept.Id = int.Parse(pamIdDept.Value.ToString());
        dept.Localidad= pamLocalidad.Value.ToString();
        dept.Nombre = nombreDept;
        await this.cn.CloseAsync();
        this.com.Parameters.Clear();
        //this.com.Parameters.AddWithValue("@nombre", nombre);
        return dept;
    }

    public async Task<int> InsertDepartamentoAsync(Departamento dept)
    {
        string sql = "SP_INSERT_DEPT";
        SqlParameter pamIdDept = new SqlParameter();
        pamIdDept.ParameterName = "@idDept";
        pamIdDept.Value = dept.Id;
        this.com.Parameters.Add(pamIdDept);
        SqlParameter paramNombreDept = new SqlParameter();
        paramNombreDept.ParameterName = "@nombreDepartamento";
        paramNombreDept.Value = dept.Nombre;
        this.com.Parameters.Add(paramNombreDept);
        SqlParameter pamLocalidad = new SqlParameter();
        pamLocalidad.ParameterName = "@localidad";
        pamLocalidad.Value = dept.Localidad;
        this.com.Parameters.Add(pamLocalidad);

        this.com.CommandType = System.Data.CommandType.StoredProcedure;
        this.com.CommandText = sql;
        await this.cn.OpenAsync();
        int registros = await this.com.ExecuteNonQueryAsync();
        await this.cn.CloseAsync();
        this.com.Parameters.Clear();
        return registros;
        //this.com.Parameters.AddWithValue("@nombre", nombre);
       // return dept;
    }

    public async Task<Empleado> GetEmpleadoAsync(string apellido)
    {
        string sql = "SP_GET_EMPLEADO_POR_APELLIDO";
        SqlParameter pamApellido = new SqlParameter();
        pamApellido.ParameterName = "@apellido";
        pamApellido.Value = apellido;
        this.com.Parameters.Add(pamApellido);

        this.com.CommandType = System.Data.CommandType.StoredProcedure;
        this.com.CommandText = sql;
        await this.cn.OpenAsync();
        this.reader = await this.com.ExecuteReaderAsync();
        Empleado emp = new Empleado();
        await this.reader.ReadAsync();
        emp.Apellido = apellido;
        emp.Oficio = this.reader["OFICIO"].ToString();
        emp.Oficio = this.reader["OFICIO"].ToString();
        emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
        await this.reader.CloseAsync();
        await this.cn.CloseAsync();
        this.com.Parameters.Clear();
        //this.com.Parameters.AddWithValue("@nombre", nombre);
        return emp;
    }

    public async Task<int> UpdateEmpleadoAsync(Empleado empUpdate)
    {
        string sql = "SP_UPDATE_EMPLEADO";
        SqlParameter pamApellido = new SqlParameter();
        pamApellido.ParameterName = "@apellido";
        pamApellido.Value = empUpdate.Apellido;
        this.com.Parameters.Add(pamApellido);
        SqlParameter paramOficioNuevo = new SqlParameter();
        paramOficioNuevo.ParameterName = "@oficioNuevo";
        paramOficioNuevo.Value = empUpdate.Oficio;
        this.com.Parameters.Add(paramOficioNuevo);
        SqlParameter pamSalarioNuevo = new SqlParameter();
        pamSalarioNuevo.ParameterName = "@salarioNuevo";
        pamSalarioNuevo.Value = empUpdate.Salario;
        this.com.Parameters.Add(pamSalarioNuevo);

        this.com.CommandType = System.Data.CommandType.StoredProcedure;
        this.com.CommandText = sql;
        await this.cn.OpenAsync();
        int registros = await this.com.ExecuteNonQueryAsync();
        await this.cn.CloseAsync();
        this.com.Parameters.Clear();
        return registros;
        //this.com.Parameters.AddWithValue("@nombre", nombre);
        // return dept;
    }
}
}
