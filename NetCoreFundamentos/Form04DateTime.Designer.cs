namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            label2 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 41);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(91, 69);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(313, 23);
            txtFecha.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(91, 107);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(117, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(91, 142);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(42, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dia";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(91, 167);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(91, 192);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 166);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(424, 163);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(383, 192);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(91, 23);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 311);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(91, 349);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(582, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}