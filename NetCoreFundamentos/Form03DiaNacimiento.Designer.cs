namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            btnMostrar = new Button();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            txtDia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(216, 228);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar dia";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(207, 104);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 1;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(207, 172);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 23);
            txtAnyo.TabIndex = 2;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(207, 33);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 41);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 104);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 180);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "Año";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(234, 276);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(0, 15);
            lblTexto.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTexto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDia);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(btnMostrar);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            Load += Form03DiaNacimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTexto;
        private Button btnMostrar;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private TextBox txtDia;
    }
}