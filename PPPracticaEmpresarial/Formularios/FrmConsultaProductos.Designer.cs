namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmConsultaProductos
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
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVentaUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CProductoCodigoBarras,
            this.CProductoNombre,
            this.CCantidad,
            this.CPrecioVentaUnitario});
            this.DgvLista.Location = new System.Drawing.Point(27, 72);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1130, 317);
            this.DgvLista.TabIndex = 2;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            this.DgvLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvLista_DataBindingComplete);
            // 
            // CProductoID
            // 
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Código";
            this.CProductoID.MinimumWidth = 8;
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            this.CProductoID.Width = 150;
            // 
            // CProductoCodigoBarras
            // 
            this.CProductoCodigoBarras.DataPropertyName = "ProductoCodigoBarras";
            this.CProductoCodigoBarras.HeaderText = "Código Barras";
            this.CProductoCodigoBarras.MinimumWidth = 8;
            this.CProductoCodigoBarras.Name = "CProductoCodigoBarras";
            this.CProductoCodigoBarras.ReadOnly = true;
            this.CProductoCodigoBarras.Width = 200;
            // 
            // CProductoNombre
            // 
            this.CProductoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProductoNombre.DataPropertyName = "ProductoNombre";
            this.CProductoNombre.HeaderText = "Producto";
            this.CProductoNombre.MinimumWidth = 8;
            this.CProductoNombre.Name = "CProductoNombre";
            this.CProductoNombre.ReadOnly = true;
            this.CProductoNombre.Width = 400;
            // 
            // CCantidad
            // 
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Stock";
            this.CCantidad.MinimumWidth = 8;
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            this.CCantidad.Width = 150;
            // 
            // CPrecioVentaUnitario
            // 
            this.CPrecioVentaUnitario.DataPropertyName = "PrecioVentaUnitario";
            this.CPrecioVentaUnitario.HeaderText = "Precio Unitario";
            this.CPrecioVentaUnitario.MinimumWidth = 8;
            this.CPrecioVentaUnitario.Name = "CPrecioVentaUnitario";
            this.CPrecioVentaUnitario.ReadOnly = true;
            this.CPrecioVentaUnitario.Width = 150;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Teal;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.Location = new System.Drawing.Point(47, 552);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(154, 43);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(884, 14);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(290, 33);
            this.CboxVerActivos.TabIndex = 8;
            this.CboxVerActivos.Text = "Ver Productos en Stock";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            this.CboxVerActivos.CheckedChanged += new System.EventHandler(this.CboxVerActivos_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.Teal;
            this.TxtBuscar.Location = new System.Drawing.Point(96, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(782, 35);
            this.TxtBuscar.TabIndex = 7;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(10, 15);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(87, 29);
            this.LblBuscar.TabIndex = 6;
            this.LblBuscar.Text = "Buscar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEliminar.Location = new System.Drawing.Point(750, 422);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(154, 43);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(994, 423);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(154, 43);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.Location = new System.Drawing.Point(255, 422);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(176, 43);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(506, 422);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(154, 43);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(37, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1185, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.DgvLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar disponibilidad de productos";
            this.Load += new System.EventHandler(this.FrmConsultaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVentaUnitario;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}