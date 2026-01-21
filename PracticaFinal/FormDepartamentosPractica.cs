using PracticaFinal.Models;
using PracticaFinal.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PracticaFinal
{

    public partial class FormDepartamentosPractica : Form
    {
        List<Departamento> departamentos;
        RepositoryDepartamentos repo;
        public FormDepartamentosPractica()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDepartamentos();
            this.departamentos = new List<Departamento>();
        }

        private async Task LoadDepartamentos()
        {
            departamentos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.Nombre);
            }
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameDept = this.cmbDepartamentos.SelectedItem.ToString();
            Departamento dept = await this.repo.GetDatosDepartamentoAsync(nameDept);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in dept.Empleados)
            {
                //this.lstEmpleados.Items.Add(emp.NumEmpleado + "-" + emp.Apellido + "-" + emp.Oficio + "-" + emp.Salario);
                this.lstEmpleados.Items.Add(emp.Apellido);
            }

            this.txtId.Text = dept.Id.ToString();
            this.txtLocalidad.Text = dept.Localidad;
            this.txtNombre.Text = dept.Nombre;

        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            Departamento deptInsert = new Departamento();
            deptInsert.Localidad = this.txtLocalidad.Text;
            deptInsert.Nombre = this.txtNombre.Text;
            deptInsert.Id = int.Parse(this.txtId.Text);
            int registros = await this.repo.InsertDepartamentoAsync(deptInsert);
            MessageBox.Show("departamentos creados: " + registros);
            await this.LoadDepartamentos();
        }

        private async void lstEmpleados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string apellidoEmp = this.lstEmpleados.SelectedItem.ToString();
            Empleado emp = await this.repo.GetEmpleadoAsync(apellidoEmp);
            this.txtApellido.Text = emp.Apellido;
            this.txtOficio.Text = emp.Oficio;
            this.txtSalario.Text = emp.Salario.ToString();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Empleado empUpdate = new Empleado();
            empUpdate.Salario = int.Parse(this.txtSalario.Text);
            empUpdate.Apellido = this.txtApellido.Text;
            empUpdate.Oficio = this.txtOficio.Text;
            int registros = await this.repo.UpdateEmpleadoAsync(empUpdate);
            MessageBox.Show("EMPLEADOS actualizados: " + registros);
            await this.LoadDepartamentos();
        }
    }
}
