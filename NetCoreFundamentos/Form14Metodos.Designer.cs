namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            Numero = new Label();
            txtNum = new TextBox();
            lblResul = new Label();
            btnValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            label1 = new Label();
            label2 = new Label();
            txtSoloNum = new TextBox();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(47, 47);
            Numero.Name = "Numero";
            Numero.Size = new Size(38, 15);
            Numero.TabIndex = 0;
            Numero.Text = "label1";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(47, 79);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Location = new Point(47, 118);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(0, 15);
            lblResul.TabIndex = 2;
            lblResul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValor
            // 
            btnValor.Location = new Point(254, 27);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(88, 75);
            btnValor.TabIndex = 3;
            btnValor.Text = "Doble valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(254, 118);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(91, 47);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(254, 190);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(88, 45);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referncia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.GradientActiveCaption;
            lblRaton.Location = new Point(434, 235);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(258, 178);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 47);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 7;
            label1.Text = "Solo numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 118);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Solo letras";
            // 
            // txtSoloNum
            // 
            txtSoloNum.Location = new Point(522, 39);
            txtSoloNum.Name = "txtSoloNum";
            txtSoloNum.Size = new Size(100, 23);
            txtSoloNum.TabIndex = 9;
            txtSoloNum.KeyPress += txtSoloNum_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(522, 118);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(100, 23);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnValor);
            Controls.Add(lblResul);
            Controls.Add(txtNum);
            Controls.Add(Numero);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Numero;
        private TextBox txtNum;
        private Label lblResul;
        private Button btnValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private Label label1;
        private Label label2;
        private TextBox txtSoloNum;
        private TextBox txtSoloLetras;
    }
}