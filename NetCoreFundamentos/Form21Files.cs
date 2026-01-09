using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;
namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper = new HelperFiles();
        public Form21Files()
        {
            InitializeComponent();
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.Path);
            this.textBox1.Text = content;
            string[] nombres = content.Split(',');
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        public string GetNombresListbox()
        {
            string data = "";
            foreach(string name in this.lstNombres.Items)
            {
                data += name + ",";
                    
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresListbox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Fichero almacenado");
        }
    }
}
