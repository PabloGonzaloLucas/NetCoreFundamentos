using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Models
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string ImagenBase64 { get; set; }
    }
}
