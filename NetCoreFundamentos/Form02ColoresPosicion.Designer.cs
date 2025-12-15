namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtRed = new TextBox();
            txtGreen = new TextBox();
            txtBlue = new TextBox();
            txtY = new TextBox();
            txtX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCambiarPosicion = new Button();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // txtRed
            // 
            txtRed.Location = new Point(44, 271);
            txtRed.Name = "txtRed";
            txtRed.Size = new Size(100, 23);
            txtRed.TabIndex = 0;
            // 
            // txtGreen
            // 
            txtGreen.Location = new Point(159, 271);
            txtGreen.Name = "txtGreen";
            txtGreen.Size = new Size(100, 23);
            txtGreen.TabIndex = 1;
            // 
            // txtBlue
            // 
            txtBlue.Location = new Point(279, 271);
            txtBlue.Name = "txtBlue";
            txtBlue.Size = new Size(100, 23);
            txtBlue.TabIndex = 2;
            // 
            // txtY
            // 
            txtY.Location = new Point(173, 119);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 3;
            // 
            // txtX
            // 
            txtX.Location = new Point(55, 119);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 90);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 5;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 90);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 6;
            label2.Text = "y";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 231);
            label3.Name = "label3";
            label3.Size = new Size(11, 15);
            label3.TabIndex = 7;
            label3.Text = "r";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 231);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 8;
            label4.Text = "g";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 231);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 9;
            label5.Text = "b";
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(289, 93);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(116, 49);
            btnCambiarPosicion.TabIndex = 10;
            btnCambiarPosicion.Text = "Cambiar Posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(451, 231);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(115, 65);
            btnCambiarColor.TabIndex = 11;
            btnCambiarColor.Text = "Cambiar color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click_1;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarColor);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtX);
            Controls.Add(txtY);
            Controls.Add(txtBlue);
            Controls.Add(txtGreen);
            Controls.Add(txtRed);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            Load += Form02ColoresPosicion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRed;
        private TextBox txtGreen;
        private TextBox txtBlue;
        private TextBox txtY;
        private TextBox txtX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCambiarPosicion;
        private Button btnCambiarColor;
    }
}