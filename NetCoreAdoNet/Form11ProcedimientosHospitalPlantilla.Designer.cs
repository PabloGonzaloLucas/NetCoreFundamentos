namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
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
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.lstPlantilla = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarSalarios = new System.Windows.Forms.Button();
            this.Plantilla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(41, 61);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(121, 21);
            this.cmbHospitales.TabIndex = 1;
            this.cmbHospitales.SelectedIndexChanged += new System.EventHandler(this.cmbHospitales_SelectedIndexChanged);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(319, 61);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 20);
            this.txtIncremento.TabIndex = 2;
            // 
            // lstPlantilla
            // 
            this.lstPlantilla.FormattingEnabled = true;
            this.lstPlantilla.Location = new System.Drawing.Point(202, 195);
            this.lstPlantilla.Name = "lstPlantilla";
            this.lstPlantilla.Size = new System.Drawing.Size(120, 95);
            this.lstPlantilla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incremento";
            // 
            // btnModificarSalarios
            // 
            this.btnModificarSalarios.Location = new System.Drawing.Point(202, 100);
            this.btnModificarSalarios.Name = "btnModificarSalarios";
            this.btnModificarSalarios.Size = new System.Drawing.Size(120, 25);
            this.btnModificarSalarios.TabIndex = 5;
            this.btnModificarSalarios.Text = "Modificar salarios";
            this.btnModificarSalarios.UseVisualStyleBackColor = true;
            this.btnModificarSalarios.Click += new System.EventHandler(this.btnModificarSalarios_Click);
            // 
            // Plantilla
            // 
            this.Plantilla.AutoSize = true;
            this.Plantilla.Location = new System.Drawing.Point(199, 160);
            this.Plantilla.Name = "Plantilla";
            this.Plantilla.Size = new System.Drawing.Size(35, 13);
            this.Plantilla.TabIndex = 6;
            this.Plantilla.Text = "label3";
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Plantilla);
            this.Controls.Add(this.btnModificarSalarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPlantilla);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.cmbHospitales);
            this.Controls.Add(this.label1);
            this.Name = "Form11ProcedimientosHospitalPlantilla";
            this.Text = "Form11ProcedimientosHospitalPlantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.ListBox lstPlantilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarSalarios;
        private System.Windows.Forms.Label Plantilla;
    }
}