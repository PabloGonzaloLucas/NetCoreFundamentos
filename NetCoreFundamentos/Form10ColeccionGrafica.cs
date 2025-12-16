using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtElem.Text;
            this.lstElem.Items.Add(elem);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElem.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string elemSeleccionado = this.lstElem.SelectedItem.ToString();
            this.lstElem.Items.Remove(elemSeleccionado);
            int index = this.lstElem.SelectedIndex;
            this.lstElem.Items.RemoveAt(index);

        }

        private void lstElem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstElem.SelectedIndex != 1) {
                this.lblIndex.Text = this.lstElem.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElem.SelectedIndex.ToString();
            }
        }
    }
}
