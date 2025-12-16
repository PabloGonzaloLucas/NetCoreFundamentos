using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElem.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtElem.Text;
            this.lstElem.Items.Add(elem);
            this.txtElem.Focus();
            this.txtElem.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (string item in this.lstElem.SelectedItems)
            {
                items += item + " , ";
            }
            foreach (int index in this.lstElem.SelectedIndices)
            {
                indices += index + " , ";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElem.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstElem.SelectedIndices.Count - 1;
            for(int i = numElementos; i >= 0; i--)
            {
                int index = this.lstElem.SelectedIndices[i];
                this.lstElem.Items.RemoveAt(index);
            }
        }
    }
}
