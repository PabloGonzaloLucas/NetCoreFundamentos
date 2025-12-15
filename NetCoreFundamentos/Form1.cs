namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int pos1 = random.Next(1,700);
            int pos2 = random.Next(1,700);
            this.Location = new Point(pos1, pos2);
            int red = random.Next(0, 255);
            int green = random.Next(0, 255);
            int blue = random.Next(0, 255);
            
            this.BackColor = Color.FromArgb(red, green, blue);

            this.txtNombre.Location = new Point(pos1,pos2);
            this.txtNombre.Text = "soy un triste texto!";
            this.txtNombre.Width = 220;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.ForeColor = Color.Aqua;
            string textoNumero = "888";
            int numero = int.Parse(textoNumero);
            int mayor = 88;
            short peque = (short)mayor;
            string dato = peque.ToString();
            dato = this.btnPulsar.ToString();
        }
    }
}
