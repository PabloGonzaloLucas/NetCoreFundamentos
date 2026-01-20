using Microsoft.Win32;
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
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        List<string> departamentos;
        List<string> apellidos;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
            
        }

        public async void LoadDepartamentos()
        {
            this.departamentos = await repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach(string dept in this.departamentos)
            {
                this.lstDepartamentos.Items.Add(dept);
            }
        }

        public async Task LoadApellidos()
        {
            string dept= this.lstDepartamentos.SelectedItem.ToString();
            this.apellidos = await this.repo.GetEmpleadosDepartamentosAsync(dept);
            this.lstEmpleados.Items.Clear();
            foreach (string apellido in this.apellidos)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
        }
     

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = this.lstDepartamentos.SelectedIndex;
            await this.LoadApellidos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            int empleadoBorrado = await this.repo.DeleteEmpleadoAsync(apellido);
            MessageBox.Show("Eliminados: " + empleadoBorrado);
            this.LoadApellidos();
        }
    }
}
