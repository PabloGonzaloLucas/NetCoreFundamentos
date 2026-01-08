using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Gonzalo";
            persona.Edad = 21;
            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.Andorra;
            this.lstPersonas.Items.Add("Nombre: " + persona.Nombre
                + " , Apellidos: " + persona.Apellidos
                + ", Edad: " + persona.Edad);
            this.lstPersonas.Items.Add(
                persona.GetNombreCompleto(true)
                );
            persona.Domicilio = new Direccion("Avenida Enero", "Lugo");
            //persona.Domicilio.Calle = "Avenida Oporto";
            //persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28019;
            this.lstPersonas.Items.Add("Direccion: "
                + persona.Domicilio.Calle + ", "
                + persona.Domicilio.Ciudad + ", "
                + persona.Domicilio.CodigoPostal + ", "
                );
            persona[0] = "Vamos 1";
            persona[1] = "Vamos 2";

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            
            this.lstPersonas.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstPersonas.Items.Add("Salario: " + emp.GetSalarioMinimo()+ "€");
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstPersonas.Items.Add("Director: " + dire.GetNombreCompleto());
            this.lstPersonas.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");

        }
    }
}
