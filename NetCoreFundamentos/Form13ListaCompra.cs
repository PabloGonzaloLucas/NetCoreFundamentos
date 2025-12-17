using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13ListaCompra : Form
    {
        public Form13ListaCompra()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            this.lstAlmacen.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string newItem = this.txtProducto.Text;
            foreach (string prod in this.lstTienda.Items)
            {
                if (prod == newItem)
                {
                    MessageBox.Show("Producto repetido");
                    return;
                }
            }
            this.lstTienda.Items.Add(newItem);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection();
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                collection.Add(this.lstTienda.Items[indice]);
                this.lstTienda.Items.RemoveAt(indice);
            }

            foreach (string producto in collection)
            {
                this.lstAlmacen.Items.Add(producto);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.Items[index].ToString();
            this.lstAlmacen.Items.Remove(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.Items[index].ToString();
            this.lstAlmacen.Items.Remove(index);
            this.lstAlmacen.Items.Insert(index + 1 , producto);
            this.lstAlmacen.SelectedIndex = index + 1 ;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if(index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
            if(index == this.lstAlmacen.Items.Count - 1)
            {
                this.btnSubir.Enabled = true;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}

