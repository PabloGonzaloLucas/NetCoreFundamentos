using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;

            if (email.IndexOf("@") == -1)
            {
                MessageBox.Show("El email debe tener @");
                return;
            }
            if(email.IndexOf("@") == 0)
            {
                MessageBox.Show("El email no puede empezar por @");
                return;
            }
            if(email.IndexOf("@") == email.Length-1)
            {
                MessageBox.Show("El email no puede terminar por @");
                return;
            }
            if(email.IndexOf("@") != 0)
            {
                int posicion = email.IndexOf("@");
                if(email.IndexOf("@",posicion+1) != -1)
                {
                    MessageBox.Show("El email no puede tener dos @");
                    return;
                }
            }
            if (!email.Contains('.'))
            {
                    MessageBox.Show("El email debe tener .");
                    return;
            }
            if (email.Contains('.'))
            {
                int posicion = email.IndexOf("@");
                if (email.IndexOf(".",posicion+1) == -1)
                {
                    MessageBox.Show("El email debe tener . despues del @");
                    return;
                }
            }
            int posicionPunto = email.IndexOf(".");
            string dominio = email.Substring(posicionPunto+1);
            if(dominio.Length <2 || dominio.Length > 3)
            {
                MessageBox.Show("El email debe tener un dominio de 2 a 3 caracteres");
                return;
            }

            MessageBox.Show("Email valido");

        }
    }
}
