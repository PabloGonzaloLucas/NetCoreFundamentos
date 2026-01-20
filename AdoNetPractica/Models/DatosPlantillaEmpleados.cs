using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetPractica.Models
{
    public class DatosPlantillaEmpleados
    {
        public List<Empleado> Empleados { get; set; }
        public int MediaSalarial { get; set; }
        public int SumaSalarial { get; set; }
        public int Personas { get; set; }
    }
}
