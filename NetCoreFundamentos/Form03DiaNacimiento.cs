using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void Form03DiaNacimiento_Load(object sender, EventArgs e)
        {

        }

      
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);

            if(mes == 1)
            {
                mes = 13;
                anyo--;
            }
            else if (mes == 2)
            {
                mes = 14;
                anyo--;
            }

            int mes2 = ((mes + 1) * 3) / 5;
            int anyo2 = anyo / 4;
            int anyo3 = anyo / 100;
            int anyo4 = anyo / 400;

            int operacionRara = dia + (mes * 2) + anyo + anyo4 + anyo2 - anyo3 + anyo4 + 2;
            int resul = operacionRara / 7;
            int resulDefinitivo = operacionRara - (resul * 7);

            switch (resulDefinitivo)
            {
                case 0: 
                    lblTexto.Text = "Tu dia es Sábado";
                    break;
                case 1: 
                    lblTexto.Text = "Tu dia es Domingo";
                    break;
                case 2: 
                    lblTexto.Text = "Tu dia es Lunes";
                    break;
                case 3: 
                    lblTexto.Text = "Tu dia es Martes";
                    break;
                case 4: 
                    lblTexto.Text = "Tu dia es Miercoles";
                    break;
                case 5: 
                    lblTexto.Text = "Tu dia es Jueves";
                    break;
                case 6: 
                    lblTexto.Text = "Tu dia es Viernes";
                    break;

            }
        }
    }
}
