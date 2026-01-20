namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleadosOficios
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
            this.lblOficios = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lstOficios = new System.Windows.Forms.ListBox();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnSubirSalario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaSalarial = new System.Windows.Forms.Label();
            this.lblMediaSalarial = new System.Windows.Forms.Label();
            this.lblMaximoSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOficios
            // 
            this.lblOficios.AutoSize = true;
            this.lblOficios.Location = new System.Drawing.Point(27, 67);
            this.lblOficios.Name = "lblOficios";
            this.lblOficios.Size = new System.Drawing.Size(37, 13);
            this.lblOficios.TabIndex = 0;
            this.lblOficios.Text = "oficios";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(175, 67);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(58, 13);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "empleados";
            // 
            // lstOficios
            // 
            this.lstOficios.FormattingEnabled = true;
            this.lstOficios.Location = new System.Drawing.Point(30, 101);
            this.lstOficios.Name = "lstOficios";
            this.lstOficios.Size = new System.Drawing.Size(120, 95);
            this.lstOficios.TabIndex = 2;
            this.lstOficios.SelectedIndexChanged += new System.EventHandler(this.lstOficios_SelectedIndexChanged);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(178, 101);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(120, 95);
            this.lstEmpleados.TabIndex = 3;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(356, 101);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 20);
            this.txtIncremento.TabIndex = 4;
            // 
            // btnSubirSalario
            // 
            this.btnSubirSalario.Location = new System.Drawing.Point(356, 143);
            this.btnSubirSalario.Name = "btnSubirSalario";
            this.btnSubirSalario.Size = new System.Drawing.Size(75, 23);
            this.btnSubirSalario.TabIndex = 5;
            this.btnSubirSalario.Text = "Subir Salarios";
            this.btnSubirSalario.UseVisualStyleBackColor = true;
            this.btnSubirSalario.Click += new System.EventHandler(this.btnSubirSalario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Incremento salarial";
            // 
            // lblSumaSalarial
            // 
            this.lblSumaSalarial.AutoSize = true;
            this.lblSumaSalarial.Location = new System.Drawing.Point(26, 224);
            this.lblSumaSalarial.Name = "lblSumaSalarial";
            this.lblSumaSalarial.Size = new System.Drawing.Size(85, 13);
            this.lblSumaSalarial.TabIndex = 7;
            this.lblSumaSalarial.Text = "lblMaximoSalario";
            // 
            // lblMediaSalarial
            // 
            this.lblMediaSalarial.AutoSize = true;
            this.lblMediaSalarial.Location = new System.Drawing.Point(30, 268);
            this.lblMediaSalarial.Name = "lblMediaSalarial";
            this.lblMediaSalarial.Size = new System.Drawing.Size(85, 13);
            this.lblMediaSalarial.TabIndex = 8;
            this.lblMediaSalarial.Text = "lblMaximoSalario";
            // 
            // lblMaximoSalario
            // 
            this.lblMaximoSalario.AutoSize = true;
            this.lblMaximoSalario.Location = new System.Drawing.Point(30, 304);
            this.lblMaximoSalario.Name = "lblMaximoSalario";
            this.lblMaximoSalario.Size = new System.Drawing.Size(85, 13);
            this.lblMaximoSalario.TabIndex = 9;
            this.lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaximoSalario);
            this.Controls.Add(this.lblMediaSalarial);
            this.Controls.Add(this.lblSumaSalarial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubirSalario);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.lstOficios);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.lblOficios);
            this.Name = "Form10UpdateEmpleadosOficios";
            this.Text = "Form10UpdateEmpleadosOficios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOficios;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.ListBox lstOficios;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Button btnSubirSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaSalarial;
        private System.Windows.Forms.Label lblMediaSalarial;
        private System.Windows.Forms.Label lblMaximoSalario;
    }
}