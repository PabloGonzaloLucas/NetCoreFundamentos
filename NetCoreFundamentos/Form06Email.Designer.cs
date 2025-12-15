namespace NetCoreFundamentos
{
    partial class Form06Email
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
            btnValidar = new Button();
            txtEmail = new TextBox();
            label1 = new Label();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(183, 102);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 46);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Introduce email";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(183, 146);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(0, 15);
            lblTexto.TabIndex = 3;
            // 
            // Form06Email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTexto);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(btnValidar);
            Name = "Form06Email";
            Text = "Form06Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox txtEmail;
        private Label label1;
        private Label lblTexto;
    }
}