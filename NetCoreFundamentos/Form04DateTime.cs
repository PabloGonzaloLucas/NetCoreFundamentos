using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFecha.Text = DateTime.Now.ToString();

        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            if (this.rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rdbMeses.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else if (this.rdbAnyos.Checked)
            {
                fecha = fecha.AddYears(incremento);
            }

                this.txtFechaFinal.Text = fecha.ToString();
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            if(this.chkFormato.Checked == true)
            {
                this.txtFecha.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFecha.Text = fecha.ToShortDateString();
            }
        }
    }
}
