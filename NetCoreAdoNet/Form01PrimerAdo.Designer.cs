namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lstApellidos = new System.Windows.Forms.ListBox();
            this.lstColumnas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lblConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(88, 105);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(91, 44);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(88, 166);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(91, 41);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(88, 227);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 47);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lstApellidos
            // 
            this.lstApellidos.FormattingEnabled = true;
            this.lstApellidos.Location = new System.Drawing.Point(260, 105);
            this.lstApellidos.Name = "lstApellidos";
            this.lstApellidos.Size = new System.Drawing.Size(154, 199);
            this.lstApellidos.TabIndex = 3;
            // 
            // lstColumnas
            // 
            this.lstColumnas.FormattingEnabled = true;
            this.lstColumnas.Location = new System.Drawing.Point(444, 105);
            this.lstColumnas.Name = "lstColumnas";
            this.lstColumnas.Size = new System.Drawing.Size(131, 199);
            this.lstColumnas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipos dato";
            // 
            // lstTipos
            // 
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.Location = new System.Drawing.Point(606, 105);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(158, 199);
            this.lstTipos.TabIndex = 8;
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(96, 335);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(61, 13);
            this.lblConexion.TabIndex = 9;
            this.lblConexion.Text = "lblConexion";
            // 
            // Form01PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstColumnas);
            this.Controls.Add(this.lstApellidos);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form01PrimerAdo";
            this.Text = "Form01PrimerAdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lstApellidos;
        private System.Windows.Forms.ListBox lstColumnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Label lblConexion;
    }
}