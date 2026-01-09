namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            btnLeerClase = new Button();
            btnGuardarClase = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(61, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(61, 151);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 119);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(61, 232);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 200);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(535, 62);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(112, 31);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardarClase
            // 
            btnGuardarClase.Location = new Point(535, 137);
            btnGuardarClase.Name = "btnGuardarClase";
            btnGuardarClase.Size = new Size(103, 37);
            btnGuardarClase.TabIndex = 7;
            btnGuardarClase.Text = "guardar clase";
            btnGuardarClase.UseVisualStyleBackColor = true;
            btnGuardarClase.Click += btnGuardarClase_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(240, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 228);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(535, 218);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(103, 37);
            btnExaminar.TabIndex = 9;
            btnExaminar.Text = "btnExaminar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardarClase);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private Button btnLeerClase;
        private Button btnGuardarClase;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}