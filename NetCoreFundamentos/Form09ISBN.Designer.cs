namespace NetCoreFundamentos
{
    partial class Form09ISBN
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
            textBox1 = new TextBox();
            label1 = new Label();
            lblISBN = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(337, 220);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(99, 28);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "btnValidar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 125);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "ISBN";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(366, 273);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(0, 15);
            lblISBN.TabIndex = 3;
            // 
            // Form09ISBN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblISBN);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnValidar);
            Name = "Form09ISBN";
            Text = "Form09ISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox textBox1;
        private Label label1;
        private Label lblISBN;
    }
}