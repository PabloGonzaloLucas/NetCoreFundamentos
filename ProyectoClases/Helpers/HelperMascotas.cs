using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private HelperFiles helper;
        private string path; 
        
        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascota.txt";
        }

        private void ConvertirMascotasList(string data)
        {
            this.Mascotas.Clear();
            string[] datosMascota = data.Split('@');
            foreach(string stringMascota in datosMascota)
            {
                string[] propiedades = stringMascota.Split(',');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);

            }
        }

        public async Task ReadMascotasAsync()
        {
            string data = await this.helper.ReadFileAsync(this.path);
            this.ConvertirMascotasList(data);
        }

        private string ConvertirMascotcasString()
        {
            string data = ";";
            foreach(Mascota mascota in this.Mascotas)
            {
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        public async Task WriteMascotasAsync()
        {
            string data = this.ConvertirMascotcasString();
            await this.helper.WriteFileAsync(this.path, data);
        }
    }
}
