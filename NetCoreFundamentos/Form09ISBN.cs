using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09ISBN : Form
    {
        public Form09ISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.textBox1.Text;
            if(isbn.Length != 10)
            {
                this.lblISBN.Text = "ISBN No valido";
                return;
            }

            int acum = isbn[0];
            for(int i = 1; i<isbn.Length; i++)
            {
                acum += isbn[i] * (i + 1);
            }
           
            if(acum % 11 == 0)
            {
                this.lblISBN.Text = "ISBN valido";
                return;
            }
            else
            {
                this.lblISBN.Text = "ISBN no valido";
                return;
            }
        }
    }
}
