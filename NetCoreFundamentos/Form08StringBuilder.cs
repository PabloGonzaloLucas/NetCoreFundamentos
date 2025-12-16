using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.rtxTexto.Text;
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempo.Text = "Segundos: "
                + krono.Elapsed.Seconds
                + ", Milisegundos: "
                + krono.Elapsed.Milliseconds;
            this.rtxTexto.Text = cadena;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.rtxTexto.Text);
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempo.Text = "Segundos: "
                + krono.Elapsed.Seconds
                + ", Milisegundos: "
                + krono.Elapsed.Milliseconds;
            this.rtxTexto.Text = cadena.ToString();
        }
    }
}
