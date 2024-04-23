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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCompraID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCompraNotas = new System.Windows.Forms.TextBox();
            this.TxtUsuarioID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.DgvLista.Size = new System.Drawing.Size(1130, 291);
            this.DgvLista.TabIndex = 2;
            this.DgvLista.VirtualMode = true;
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
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.Teal;
            this.TxtBuscar.Location = new System.Drawing.Point(96, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(1061, 35);
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
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(970, 645);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(154, 43);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(970, 555);
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
            this.button1.Location = new System.Drawing.Point(970, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCompraID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCompraNotas);
            this.groupBox1.Controls.Add(this.TxtUsuarioID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 360);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Compra";
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.Location = new System.Drawing.Point(258, 154);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(586, 35);
            this.TxtProveedorID.TabIndex = 31;
            this.TxtProveedorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Código Proveedor: ";
            // 
            // TxtCompraID
            // 
            this.TxtCompraID.Location = new System.Drawing.Point(258, 99);
            this.TxtCompraID.Name = "TxtCompraID";
            this.TxtCompraID.ReadOnly = true;
            this.TxtCompraID.Size = new System.Drawing.Size(586, 35);
            this.TxtCompraID.TabIndex = 29;
            this.TxtCompraID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Código Compra: ";
            // 
            // TxtCompraNotas
            // 
            this.TxtCompraNotas.Location = new System.Drawing.Point(258, 207);
            this.TxtCompraNotas.Multiline = true;
            this.TxtCompraNotas.Name = "TxtCompraNotas";
            this.TxtCompraNotas.ReadOnly = true;
            this.TxtCompraNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtCompraNotas.Size = new System.Drawing.Size(586, 132);
            this.TxtCompraNotas.TabIndex = 27;
            // 
            // TxtUsuarioID
            // 
            this.TxtUsuarioID.Location = new System.Drawing.Point(258, 46);
            this.TxtUsuarioID.Name = "TxtUsuarioID";
            this.TxtUsuarioID.ReadOnly = true;
            this.TxtUsuarioID.Size = new System.Drawing.Size(586, 35);
            this.TxtUsuarioID.TabIndex = 26;
            this.TxtUsuarioID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código Usuario: ";
            // 
            // FrmConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1185, 751);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.DgvLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar lista de compras";
            this.Load += new System.EventHandler(this.FrmConsultaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCompraID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCompraNotas;
        private System.Windows.Forms.TextBox TxtUsuarioID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}