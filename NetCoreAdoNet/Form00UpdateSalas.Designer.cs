namespace NetCoreAdoNet
{
    partial class Form00UpdateSalas
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
            this.txtSala = new System.Windows.Forms.TextBox();
            this.btnUpdateSalas = new System.Windows.Forms.Button();
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuevo nombre";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(257, 97);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 2;
            // 
            // btnUpdateSalas
            // 
            this.btnUpdateSalas.Location = new System.Drawing.Point(257, 137);
            this.btnUpdateSalas.Name = "btnUpdateSalas";
            this.btnUpdateSalas.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSalas.TabIndex = 3;
            this.btnUpdateSalas.Text = "UpdateSalas";
            this.btnUpdateSalas.UseVisualStyleBackColor = true;
            this.btnUpdateSalas.Click += new System.EventHandler(this.btnUpdateSalas_Click);
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.Location = new System.Drawing.Point(58, 112);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(120, 95);
            this.lstSalas.TabIndex = 4;
            // 
            // Form00UpdateSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSalas);
            this.Controls.Add(this.btnUpdateSalas);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form00UpdateSalas";
            this.Text = "Form04UpdateSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Button btnUpdateSalas;
        private System.Windows.Forms.ListBox lstSalas;
    }
}