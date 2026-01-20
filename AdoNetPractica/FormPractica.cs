using AdoNetPractica.Models;
using AdoNetPractica.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetPractica
{
    public partial class FormPractica : Form
    {
        RepositoryEmpleados repo;
        public FormPractica()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleados();
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            List<string> hospitales = await this.repo.GetNombresHospitalesAsync();
            this.cmbHospitales.Items.Clear();
            foreach(string hospital in hospitales)
            {
                this.cmbHospitales.Items.Add(hospital);
            }
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosPlantillaEmpleados plantilla = new DatosPlantillaEmpleados();
            plantilla = await this.repo.GetEmpleadosAsync(this.cmbHospitales.SelectedItem.ToString());
            this.lstEmpleados.Items.Clear();
            foreach(Empleado emp in plantilla.Empleados)
            {
                lstEmpleados.Items.Add(emp.NumEmpleado.ToString() + " - " + emp.Apellido + " - " + emp.Especialidad + " - " + emp.Salario.ToString());
            }
            this.txtMedia.Text = plantilla.MediaSalarial.ToString();
            this.txtSuma.Text = plantilla.SumaSalarial.ToString();
            this.txtPersonas.Text = plantilla.Personas.ToString();
        }
    }
}
