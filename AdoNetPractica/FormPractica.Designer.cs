namespace AdoNetPractica
{
    partial class FormPractica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleados Hospital";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(105, 59);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(121, 21);
            this.cmbHospitales.TabIndex = 2;
            this.cmbHospitales.SelectedIndexChanged += new System.EventHandler(this.cmbHospitales_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma salarial";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(105, 199);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(105, 290);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Media salarial";
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(105, 376);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(100, 20);
            this.txtPersonas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personas";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(381, 59);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(272, 316);
            this.lstEmpleados.TabIndex = 9;
            // 
            // FormPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHospitales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPractica";
            this.Text = "FormPractica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstEmpleados;
    }
}