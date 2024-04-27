namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmConsultaInformacionCompra
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCompraFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCompraID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCompraNotas = new System.Windows.Forms.TextBox();
            this.TxtUsuarioID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CCompraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCompraNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCompraTipoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCompraFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCompraNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CCompraID,
            this.CCompraNumero,
            this.CCompraTipoDescripcion,
            this.CUsuarioID,
            this.CProveedorID,
            this.CCompraFecha,
            this.CCompraNotas});
            this.DgvLista.Location = new System.Drawing.Point(27, 72);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1130, 249);
            this.DgvLista.TabIndex = 2;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            this.DgvLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvLista_DataBindingComplete);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.Teal;
            this.TxtBuscar.Location = new System.Drawing.Point(122, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(1000, 35);
            this.TxtBuscar.TabIndex = 7;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(27, 15);
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
            this.BtnCancelar.Location = new System.Drawing.Point(982, 624);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(982, 534);
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
            this.button1.Location = new System.Drawing.Point(982, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.TxtCompraFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCompraID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCompraNotas);
            this.groupBox1.Controls.Add(this.TxtUsuarioID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 405);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Compra";
            // 
            // TxtCompraFecha
            // 
            this.TxtCompraFecha.BackColor = System.Drawing.Color.Azure;
            this.TxtCompraFecha.Location = new System.Drawing.Point(258, 351);
            this.TxtCompraFecha.Name = "TxtCompraFecha";
            this.TxtCompraFecha.ReadOnly = true;
            this.TxtCompraFecha.Size = new System.Drawing.Size(586, 35);
            this.TxtCompraFecha.TabIndex = 33;
            this.TxtCompraFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Compra Fecha:";
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.BackColor = System.Drawing.Color.Azure;
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
            this.TxtCompraID.BackColor = System.Drawing.Color.Azure;
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
            this.TxtCompraNotas.BackColor = System.Drawing.Color.Azure;
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
            this.TxtUsuarioID.BackColor = System.Drawing.Color.Azure;
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
            this.label8.Size = new System.Drawing.Size(174, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Compra Notas:";
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
            // CCompraID
            // 
            this.CCompraID.DataPropertyName = "CompraID";
            this.CCompraID.HeaderText = "Cód.Compra";
            this.CCompraID.MinimumWidth = 8;
            this.CCompraID.Name = "CCompraID";
            this.CCompraID.ReadOnly = true;
            this.CCompraID.Width = 150;
            // 
            // CCompraNumero
            // 
            this.CCompraNumero.DataPropertyName = "CompraNumero";
            this.CCompraNumero.HeaderText = "Número de Compra";
            this.CCompraNumero.MinimumWidth = 8;
            this.CCompraNumero.Name = "CCompraNumero";
            this.CCompraNumero.ReadOnly = true;
            this.CCompraNumero.Width = 150;
            // 
            // CCompraTipoDescripcion
            // 
            this.CCompraTipoDescripcion.DataPropertyName = "CompraTipoDescripcion";
            this.CCompraTipoDescripcion.HeaderText = "Tipo Compra";
            this.CCompraTipoDescripcion.MinimumWidth = 8;
            this.CCompraTipoDescripcion.Name = "CCompraTipoDescripcion";
            this.CCompraTipoDescripcion.ReadOnly = true;
            this.CCompraTipoDescripcion.Width = 150;
            // 
            // CUsuarioID
            // 
            this.CUsuarioID.DataPropertyName = "UsuarioID";
            this.CUsuarioID.HeaderText = "Usuario Encargado";
            this.CUsuarioID.MinimumWidth = 8;
            this.CUsuarioID.Name = "CUsuarioID";
            this.CUsuarioID.ReadOnly = true;
            this.CUsuarioID.Width = 150;
            // 
            // CProveedorID
            // 
            this.CProveedorID.DataPropertyName = "ProveedorID";
            this.CProveedorID.HeaderText = "Cód.Proveedor";
            this.CProveedorID.MinimumWidth = 8;
            this.CProveedorID.Name = "CProveedorID";
            this.CProveedorID.ReadOnly = true;
            this.CProveedorID.Width = 150;
            // 
            // CCompraFecha
            // 
            this.CCompraFecha.DataPropertyName = "CompraFecha";
            this.CCompraFecha.HeaderText = "Fecha de la Compra";
            this.CCompraFecha.MinimumWidth = 8;
            this.CCompraFecha.Name = "CCompraFecha";
            this.CCompraFecha.ReadOnly = true;
            this.CCompraFecha.Width = 150;
            // 
            // CCompraNotas
            // 
            this.CCompraNotas.DataPropertyName = "CompraNotas";
            this.CCompraNotas.HeaderText = "Detalle - Notas";
            this.CCompraNotas.MinimumWidth = 8;
            this.CCompraNotas.Name = "CCompraNotas";
            this.CCompraNotas.ReadOnly = true;
            this.CCompraNotas.Width = 150;
            // 
            // FrmConsultaInformacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1185, 768);
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
            this.Name = "FrmConsultaInformacionCompra";
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
        private System.Windows.Forms.TextBox TxtCompraFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCompraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCompraNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCompraTipoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCompraFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCompraNotas;
    }
}