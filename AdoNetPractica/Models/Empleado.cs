using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetPractica.Models
{
    public class Empleado
    {
        public int HospitalCod { get; set; }
        public int NumEmpleado { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public int Salario { get; set; }
    }
}
