namespace PryRecetas
{
    partial class FormRecetas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevaRe = new System.Windows.Forms.Button();
            this.btnGuardarRe = new System.Windows.Forms.Button();
            this.btnRecetasCreadas = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaRe
            // 
            this.btnNuevaRe.Location = new System.Drawing.Point(12, 310);
            this.btnNuevaRe.Name = "btnNuevaRe";
            this.btnNuevaRe.Size = new System.Drawing.Size(90, 23);
            this.btnNuevaRe.TabIndex = 2;
            this.btnNuevaRe.Text = "Nueva Receta";
            this.btnNuevaRe.UseVisualStyleBackColor = true;
            this.btnNuevaRe.Click += new System.EventHandler(this.btnNuevaRe_Click);
            // 
            // btnGuardarRe
            // 
            this.btnGuardarRe.Location = new System.Drawing.Point(125, 310);
            this.btnGuardarRe.Name = "btnGuardarRe";
            this.btnGuardarRe.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRe.TabIndex = 3;
            this.btnGuardarRe.Text = "Guardar Receta";
            this.btnGuardarRe.UseVisualStyleBackColor = true;
            // 
            // btnRecetasCreadas
            // 
            this.btnRecetasCreadas.Location = new System.Drawing.Point(641, 224);
            this.btnRecetasCreadas.Name = "btnRecetasCreadas";
            this.btnRecetasCreadas.Size = new System.Drawing.Size(108, 23);
            this.btnRecetasCreadas.TabIndex = 4;
            this.btnRecetasCreadas.Text = "BUSCAR Recetas";
            this.btnRecetasCreadas.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(93, 264);
            this.nudCantidad.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(107, 20);
            this.nudCantidad.TabIndex = 5;
            this.nudCantidad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(223, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(396, 354);
            this.dgvLista.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(33, 266);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(48, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "cantidad";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(641, 198);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Location = new System.Drawing.Point(33, 114);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(120, 13);
            this.lblIngrediente.TabIndex = 9;
            this.lblIngrediente.Text = "Nombre de Ingredientes";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre de Recetas";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(12, 141);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(188, 20);
            this.txtIngredientes.TabIndex = 12;
            // 
            // FormRecetas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIngrediente);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnRecetasCreadas);
            this.Controls.Add(this.btnGuardarRe);
            this.Controls.Add(this.btnNuevaRe);
            this.Name = "FormRecetas";
            this.Text = "Lista de recetas";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevaRe;
        private System.Windows.Forms.Button btnGuardarRe;
        private System.Windows.Forms.Button btnRecetasCreadas;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIngredientes;
    }
}

