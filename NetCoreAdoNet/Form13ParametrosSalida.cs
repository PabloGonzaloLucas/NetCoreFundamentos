using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region procedures

//create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre NVARCHAR(50), @suma int OUT, @media int OUT, @personas int OUT)
//as 
//    declare @iddept int
//    select @iddept = DEPT_NO from DEPT
//    where DNOMBRE = @nombre
//    select * from EMP where DEPT_NO = @iddept
//    select @suma = SUM(SALARIO), @media = AVG(SALARIO),
//    @personas = COUNT(EMP_NO) from EMP
//    where DEPT_NO = @iddept
//go


#endregion
namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        RepositoryParametersOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametersOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach(string nombre in departamentos)
            {
                this.cmbDepartamentos.Items.Add(nombre);
            }
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut model = await this.repo.GetEmpleadosModelAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach(string ape in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtMedia.Text = model.MediaSalarial.ToString();
            this.txtSuma.Text = model.SumaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();
        }
    }
}
