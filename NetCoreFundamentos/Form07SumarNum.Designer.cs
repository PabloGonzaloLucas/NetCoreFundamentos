namespace NetCoreFundamentos
{
    partial class Form07SumarNum
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
            btnSumar = new Button();
            txtNumeros = new TextBox();
            lblText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 79);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca numeros";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(172, 154);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 1;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(172, 107);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 2;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(172, 192);
            lblText.Name = "lblText";
            lblText.Size = new Size(0, 15);
            lblText.TabIndex = 3;
            // 
            // Form07SumarNum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblText);
            Controls.Add(txtNumeros);
            Controls.Add(btnSumar);
            Controls.Add(label1);
            Name = "Form07SumarNum";
            Text = "Form07SumarNum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSumar;
        private TextBox txtNumeros;
        private Label lblText;
    }
}