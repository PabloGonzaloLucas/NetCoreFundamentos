using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            List<Control> botones = new List<Control>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            this.button1.Click += Button1_Click;


            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            foreach(Button boton in coleccion)
            {
                boton.BackColor = Color.LightGreen;
            }
            coleccion.Add(this.textBox1);
            foreach(Control control in coleccion)
            {
                control.BackColor = Color.LightSalmon;
                if(control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }

    }
}
