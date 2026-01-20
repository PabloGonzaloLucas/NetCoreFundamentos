namespace NetCoreAdoNet
{
    partial class Form06UpdateSalasClases
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
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.btnUpdateSalas = new System.Windows.Forms.Button();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.Location = new System.Drawing.Point(86, 97);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(120, 95);
            this.lstSalas.TabIndex = 9;
            // 
            // btnUpdateSalas
            // 
            this.btnUpdateSalas.Location = new System.Drawing.Point(285, 122);
            this.btnUpdateSalas.Name = "btnUpdateSalas";
            this.btnUpdateSalas.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSalas.TabIndex = 8;
            this.btnUpdateSalas.Text = "UpdateSalas";
            this.btnUpdateSalas.UseVisualStyleBackColor = true;
            this.btnUpdateSalas.Click += new System.EventHandler(this.btnUpdateSalas_Click_1);
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(285, 82);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nuevo nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salas";
            // 
            // Form06UpdateSalasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSalas);
            this.Controls.Add(this.btnUpdateSalas);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form06UpdateSalasClases";
            this.Text = "Form06UpdateSalasClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.Button btnUpdateSalas;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}