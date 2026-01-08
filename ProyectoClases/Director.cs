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


    }
}
