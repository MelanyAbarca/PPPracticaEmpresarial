namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmProductosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosGestion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxCompraTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnProveedorBuscar = new System.Windows.Forms.Button();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnProductoAgregar = new System.Windows.Forms.ToolStripButton();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVentaUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCrearProducto = new System.Windows.Forms.Button();
            this.BtnListaCompras = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboxCompraTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnProveedorBuscar);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(735, 68);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(416, 107);
            this.TxtNotas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notas";
            // 
            // CboxCompraTipo
            // 
            this.CboxCompraTipo.BackColor = System.Drawing.Color.LightCyan;
            this.CboxCompraTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCompraTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxCompraTipo.FormattingEnabled = true;
            this.CboxCompraTipo.Location = new System.Drawing.Point(204, 120);
            this.CboxCompraTipo.Name = "CboxCompraTipo";
            this.CboxCompraTipo.Size = new System.Drawing.Size(494, 37);
            this.CboxCompraTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Compra";
            // 
            // BtnProveedorBuscar
            // 
            this.BtnProveedorBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnProveedorBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedorBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnProveedorBuscar.Location = new System.Drawing.Point(621, 66);
            this.BtnProveedorBuscar.Name = "BtnProveedorBuscar";
            this.BtnProveedorBuscar.Size = new System.Drawing.Size(77, 35);
            this.BtnProveedorBuscar.TabIndex = 2;
            this.BtnProveedorBuscar.Text = "···";
            this.BtnProveedorBuscar.UseVisualStyleBackColor = false;
            this.BtnProveedorBuscar.Click += new System.EventHandler(this.BtnProveedorBuscar_Click);
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.BackColor = System.Drawing.Color.MintCream;
            this.TxtProveedorNombre.Location = new System.Drawing.Point(204, 66);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.ReadOnly = true;
            this.TxtProveedorNombre.Size = new System.Drawing.Size(411, 35);
            this.TxtProveedorNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnProductoAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1163, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnProductoAgregar
            // 
            this.BtnProductoAgregar.BackColor = System.Drawing.Color.Teal;
            this.BtnProductoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductoAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProductoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoAgregar.Image")));
            this.BtnProductoAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoAgregar.Name = "BtnProductoAgregar";
            this.BtnProductoAgregar.Size = new System.Drawing.Size(230, 33);
            this.BtnProductoAgregar.Text = "Agregar Producto";
            this.BtnProductoAgregar.Click += new System.EventHandler(this.BtnProductoAgregar_Click);
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
            this.DgvLista.Location = new System.Drawing.Point(21, 73);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1130, 150);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(29, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1169, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "CANTIDAD PRODUCTOS";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TxtTotalCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCantidad.Location = new System.Drawing.Point(266, 73);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(267, 39);
            this.TxtTotalCantidad.TabIndex = 1;
            this.TxtTotalCantidad.Text = "0";
            this.TxtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(634, 73);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(267, 39);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.TxtTotalCantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(29, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1169, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL";
            // 
            // BtnCrearProducto
            // 
            this.BtnCrearProducto.BackColor = System.Drawing.Color.Teal;
            this.BtnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCrearProducto.Location = new System.Drawing.Point(116, 604);
            this.BtnCrearProducto.Name = "BtnCrearProducto";
            this.BtnCrearProducto.Size = new System.Drawing.Size(310, 42);
            this.BtnCrearProducto.TabIndex = 3;
            this.BtnCrearProducto.Text = "Almacenar Información";
            this.BtnCrearProducto.UseVisualStyleBackColor = false;
            this.BtnCrearProducto.Click += new System.EventHandler(this.BtnCrearProducto_Click);
            // 
            // BtnListaCompras
            // 
            this.BtnListaCompras.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnListaCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnListaCompras.Location = new System.Drawing.Point(458, 604);
            this.BtnListaCompras.Name = "BtnListaCompras";
            this.BtnListaCompras.Size = new System.Drawing.Size(310, 42);
            this.BtnListaCompras.TabIndex = 4;
            this.BtnListaCompras.Text = "Ver Lista de Compras";
            this.BtnListaCompras.UseVisualStyleBackColor = false;
            this.BtnListaCompras.Click += new System.EventHandler(this.BtnListaCompras_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(800, 604);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(310, 43);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmProductosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1227, 658);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnListaCompras);
            this.Controls.Add(this.BtnCrearProducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Productos";
            this.Load += new System.EventHandler(this.FrmProductosGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnProveedorBuscar;
        private System.Windows.Forms.ComboBox CboxCompraTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnProductoAgregar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVentaUnitario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCrearProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnListaCompras;
        private System.Windows.Forms.Button BtnCancelar;
    }
}