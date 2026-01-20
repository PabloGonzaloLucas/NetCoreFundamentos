using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAdoNet.Models
{
    public class EmpleadosParametersOut
    {
        public List<string> Apellidos { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }

        public EmpleadosParametersOut()
        {
            this.Apellidos = new List<string>();
        }
    }
}
