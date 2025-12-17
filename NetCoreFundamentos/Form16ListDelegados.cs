using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            this.contador = 0; 
            List<Button> botones = new List<Button>();
            foreach(Control control in this.Controls)
            {
                if(control is Button)
                {
                    botones.Add((Button)control);
                }
            }

            foreach(Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            ((Button)sender).BackColor = Color.LightPink;
        }
    }
}
