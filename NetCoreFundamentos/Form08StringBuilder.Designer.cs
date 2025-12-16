namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            lbl = new Label();
            rtxTexto = new RichTextBox();
            lblTiempo = new Label();
            btnInvertir = new Button();
            btnInvertirStringBuilder = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(71, 65);
            lbl.Name = "lbl";
            lbl.Size = new Size(139, 15);
            lbl.TabIndex = 0;
            lbl.Text = "Copia texto para trabajar:";
            // 
            // rtxTexto
            // 
            rtxTexto.Location = new Point(71, 98);
            rtxTexto.Name = "rtxTexto";
            rtxTexto.Size = new Size(331, 157);
            rtxTexto.TabIndex = 1;
            rtxTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(71, 275);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 15);
            lblTiempo.TabIndex = 2;
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(71, 313);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(101, 57);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir String";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(296, 313);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(106, 57);
            btnInvertirStringBuilder.TabIndex = 4;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(lblTiempo);
            Controls.Add(rtxTexto);
            Controls.Add(lbl);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private RichTextBox rtxTexto;
        private Label lblTiempo;
        private Button btnInvertir;
        private Button btnInvertirStringBuilder;
    }
}