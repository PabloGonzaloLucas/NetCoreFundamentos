using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form09CrudHospital : Form
    {
        RepositoryHospitales repo;
        public Form09CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        private async Task LoadHospitales()
        {
            List<Hospital> hospitals = await this.repo.GetHospitalesAsync();
            this.lstHospital.Items.Clear();
            foreach(Hospital hospital in hospitals)
            {
                this.lstHospital.Items.Add(hospital.Hospital_cod + " - " + hospital.Nombre + " - " + hospital.Direccion + " - " + hospital.Telefono + " - " + hospital.Num_cama + " Camas");
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text.ToString());
            string nombre = this.txtNombre.Text.ToString();
            string direccion = this.txtDireccion.Text.ToString();
            string telefono = this.txtTelefono.Text.ToString();
            int camas = int.Parse(this.txtCamas.Text.ToString());
            await this.repo.CreateHospitalAsync(id, nombre, direccion, telefono, camas);
            await this.LoadHospitales();
        }
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text.ToString());
            string nombre = this.txtNombre.Text.ToString();
            string direccion = this.txtDireccion.Text.ToString();
            string telefono = this.txtTelefono.Text.ToString();
            int camas = int.Parse(this.txtCamas.Text.ToString());
            await this.repo.UpdateHospitalAsync(id, nombre, direccion, telefono, camas);
            await this.LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text.ToString());
            await this.repo.DeleteHospitalAsync(id);
            await this.LoadHospitales();
        }

    }
}
