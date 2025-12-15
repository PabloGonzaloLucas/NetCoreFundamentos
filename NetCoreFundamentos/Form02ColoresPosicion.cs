using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void Form02ColoresPosicion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtX.Text);
            int posY = int.Parse(this.txtY.Text);
            this.Location = new Point(posX, posY);
        }

        private void btnCambiarColor_Click_1(object sender, EventArgs e)
        {
            int r = int.Parse(this.txtRed.Text);
            int g = int.Parse(this.txtGreen.Text);
            int b = int.Parse(this.txtBlue.Text);
            if(r < 0 || r > 255)
            {
                MessageBox.Show("El valor de rojo debe estar comprendido entre 0 y 255");
            }
            else if(g < 0 || g > 255)
            {
                MessageBox.Show("El valor de verde debe estar comprendido entre 0 y 255");
            }
            else if(b < 0 || b > 255)
            {
                MessageBox.Show("El valor de azul debe estar comprendido entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
