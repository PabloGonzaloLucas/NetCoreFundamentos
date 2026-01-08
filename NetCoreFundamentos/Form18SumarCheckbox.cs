using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{

    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> checks;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.checks = new List<CheckBox>();
            foreach(CheckBox chk in this.groupBox1.Controls)
            {
                this.checks.Add(chk);
                chk.CheckedChanged += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox checkCambiado = (CheckBox)sender;
            int numero = int.Parse(checkCambiado.Text);
            int suma = int.Parse(this.txtSuma.Text);
            if (checkCambiado.Checked)
            {
                suma += numero;
            }
            else
            {
                suma -= numero;
            }
                this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox chk in this.checks)
            {
                int aleat = random.Next(1, 50);
                chk.Text = aleat.ToString();
            }
        }
    }
}
