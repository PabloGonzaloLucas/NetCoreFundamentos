using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarNum : Form
    {
        public Form07SumarNum()
        {
            
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string numeros = this.txtNumeros.Text;
            int resul = 0;
            for(int i =0; i<numeros.Length; i++)
            {
                char caracter = numeros[i];
                int numero = int.Parse(caracter.ToString());
                //Convert.ToInt32(caracter);
                resul += numero;
            }

            this.lblText.Text = resul.ToString();
        }
    }
}
