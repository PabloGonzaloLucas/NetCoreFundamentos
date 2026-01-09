using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }
        public Empleado() 
        {
            Debug.WriteLine("Constructor de EMPLEADO vacio");
            this.SalarioMinimo = 1600;
        }

        public Empleado(string nombre, string apellidos)
            : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con dos parametros");
        }
        public Empleado(string nombre, string apellidos, int edad)
            : base(nombre, apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            Debug.WriteLine("Constructor EMPLEADO con dos parametros");
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

    }
}
