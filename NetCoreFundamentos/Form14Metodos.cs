using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        void GetDobleValor(int numero)
        {
            numero = numero * 3;
        }

        int GetDoble(int numero)
        {
            return numero * 2;
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            int resultado = this.GetDoble(num);
            this.GetDobleValor(num);
            this.lblResul.Text = num.ToString();

        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightGoldenrodYellow;
        }
        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnValor);
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            this.GetDobleReferencia(ref num);
            this.lblResul.Text = num.ToString();
        }
        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }

            char caracter = e.KeyChar;
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }

            char caracter = e.KeyChar;
        }
    }
}
