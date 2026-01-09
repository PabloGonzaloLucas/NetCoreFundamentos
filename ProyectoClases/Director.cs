using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("COonstructor DIRECTOR");
            this.SalarioMinimo = SalarioMinimo + 200;
        }
        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return base.GetDiasVacaciones() + 8;
            
        }

    }
}
