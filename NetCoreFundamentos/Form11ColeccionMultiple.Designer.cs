namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            txtElem = new TextBox();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsert = new Button();
            lstElem = new ListBox();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(245, 366);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 15);
            lblIndex.TabIndex = 15;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(245, 298);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 14;
            lblItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtElem
            // 
            txtElem.Location = new Point(472, 117);
            txtElem.Name = "txtElem";
            txtElem.Size = new Size(100, 23);
            txtElem.TabIndex = 13;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(497, 263);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(75, 23);
            btnBorrarTodo.TabIndex = 12;
            btnBorrarTodo.Text = "borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(497, 217);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(497, 155);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lstElem
            // 
            lstElem.FormattingEnabled = true;
            lstElem.Location = new Point(245, 155);
            lstElem.Name = "lstElem";
            lstElem.Size = new Size(120, 94);
            lstElem.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(497, 316);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(75, 23);
            btnSeleccionados.TabIndex = 16;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(txtElem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsert);
            Controls.Add(lstElem);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private TextBox txtElem;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsert;
        private ListBox lstElem;
        private Label label1;
        private Button btnSeleccionados;
    }
}