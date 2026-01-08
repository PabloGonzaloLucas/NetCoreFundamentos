using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> buttons;
        List<TextBox> resultados;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            buttons = new List<Button>();
            resultados = new List<TextBox>();
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is Button)
                {
                    buttons.Add((Button)ctrl);
                }
                else if(ctrl is TextBox)
                {
                    resultados.Add((TextBox)ctrl);
                }

            }
            Random random = new Random();
            foreach (Button button in buttons)
            {
                int aleat = random.Next(1, 50);
                button.Text = aleat.ToString();
                button.Click += GenerarTabla;
            }

            resultados.Reverse();
        }

        private void GenerarTabla(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int i = 1;
            foreach(TextBox txt in resultados)
            {
                txt.Text = (int.Parse(botonPulsado.Text) * i).ToString();
                i++;
            }
        }
    }
}
