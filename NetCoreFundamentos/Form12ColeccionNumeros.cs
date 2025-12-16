using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 10000);
                this.lstNumeros.Items.Add(num);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = Convert.ToInt32(this.lstNumeros.Items[0]);
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach(int num in this.lstNumeros.Items)
            {
                suma += num;
                if(num % 2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
