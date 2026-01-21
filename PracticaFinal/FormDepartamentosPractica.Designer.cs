namespace PracticaFinal
{
    partial class FormDepartamentosPractica
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lstEmpleados = new ListBox();
            cmbDepartamentos = new ComboBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            txtApellido = new TextBox();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            btnUpdate = new Button();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 90);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 246);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Localidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 49);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 40);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(576, 136);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Oficio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(576, 212);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 7;
            label8.Text = "Salario";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(264, 90);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(240, 259);
            lstEmpleados.TabIndex = 8;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged_1;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(55, 49);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 9;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 128);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(55, 194);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(55, 274);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(576, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(576, 168);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 14;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(576, 246);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(576, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 42);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(55, 338);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(121, 39);
            btnInsertar.TabIndex = 17;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // FormDepartamentosPractica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsertar);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(cmbDepartamentos);
            Controls.Add(lstEmpleados);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDepartamentosPractica";
            Text = "FormDepartamentosPractica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox lstEmpleados;
        private ComboBox cmbDepartamentos;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private TextBox txtApellido;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private Button btnUpdate;
        private Button btnInsertar;
    }
}