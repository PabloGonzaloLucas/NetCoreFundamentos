namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardarClase = new Button();
            btnLeerClase = new Button();
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnNuevaMascota = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(542, 158);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(112, 37);
            btnGuardarClase.TabIndex = 15;
            btnGuardarClase.Text = "guardar clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(542, 83);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(112, 31);
            btnLeerClase.TabIndex = 14;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(68, 253);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 221);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(68, 172);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 140);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 10;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 59);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(286, 98);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(209, 319);
            lstMascotas.TabIndex = 17;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(68, 319);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(130, 23);
            btnNuevaMascota.TabIndex = 18;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(542, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(680, 172);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(93, 43);
            btnExaminar.TabIndex = 20;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarClase;
        private Button btnLeerClase;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnNuevaMascota;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}