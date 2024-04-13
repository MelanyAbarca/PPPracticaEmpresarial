namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmProveedoresGestion
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
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.TxtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.CbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.TxtProveedorCorreo = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtProveedorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProveedorCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoProveedorDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Location = new System.Drawing.Point(1176, 37);
            this.CboxVerActivos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(303, 33);
            this.CboxVerActivos.TabIndex = 5;
            this.CboxVerActivos.Text = "Ver Proveedores Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarProveedor
            // 
            this.TxtBuscarProveedor.ForeColor = System.Drawing.Color.Teal;
            this.TxtBuscarProveedor.Location = new System.Drawing.Point(134, 35);
            this.TxtBuscarProveedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtBuscarProveedor.Name = "TxtBuscarProveedor";
            this.TxtBuscarProveedor.Size = new System.Drawing.Size(1032, 35);
            this.TxtBuscarProveedor.TabIndex = 4;
            this.TxtBuscarProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(33, 35);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(87, 29);
            this.LblBuscar.TabIndex = 3;
            this.LblBuscar.Text = "Buscar";
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProveedorID,
            this.CProveedorNombre,
            this.CProveedorCedula,
            this.CProveedorCorreo,
            this.CTipoProveedorDescripcion});
            this.DgLista.Location = new System.Drawing.Point(27, 411);
            this.DgLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 62;
            this.DgLista.RowTemplate.Height = 28;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(1440, 204);
            this.DgLista.TabIndex = 6;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtProveedorDireccion);
            this.groupBox1.Controls.Add(this.CbTipoProveedor);
            this.groupBox1.Controls.Add(this.TxtProveedorCorreo);
            this.groupBox1.Controls.Add(this.TxtProveedorCedula);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.TxtProveedorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1440, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Proveedor";
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(915, 82);
            this.TxtProveedorDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(509, 131);
            this.TxtProveedorDireccion.TabIndex = 15;
            // 
            // CbTipoProveedor
            // 
            this.CbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoProveedor.FormattingEnabled = true;
            this.CbTipoProveedor.Location = new System.Drawing.Point(981, 35);
            this.CbTipoProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbTipoProveedor.Name = "CbTipoProveedor";
            this.CbTipoProveedor.Size = new System.Drawing.Size(443, 37);
            this.CbTipoProveedor.TabIndex = 14;
            // 
            // TxtProveedorCorreo
            // 
            this.TxtProveedorCorreo.Location = new System.Drawing.Point(183, 177);
            this.TxtProveedorCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProveedorCorreo.Name = "TxtProveedorCorreo";
            this.TxtProveedorCorreo.Size = new System.Drawing.Size(531, 35);
            this.TxtProveedorCorreo.TabIndex = 12;
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.Location = new System.Drawing.Point(183, 128);
            this.TxtProveedorCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(531, 35);
            this.TxtProveedorCedula.TabIndex = 10;
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(183, 81);
            this.TxtProveedorNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(531, 35);
            this.TxtProveedorNombre.TabIndex = 9;
            // 
            // TxtProveedorID
            // 
            this.TxtProveedorID.Location = new System.Drawing.Point(248, 37);
            this.TxtProveedorID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtProveedorID.Name = "TxtProveedorID";
            this.TxtProveedorID.ReadOnly = true;
            this.TxtProveedorID.Size = new System.Drawing.Size(466, 35);
            this.TxtProveedorID.TabIndex = 8;
            this.TxtProveedorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Proveedor: ";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEliminar.Location = new System.Drawing.Point(1104, 345);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(196, 43);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(649, 636);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(196, 43);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.Location = new System.Drawing.Point(494, 345);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(205, 43);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(803, 345);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(196, 43);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Teal;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.Location = new System.Drawing.Point(194, 345);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(196, 43);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CProveedorID
            // 
            this.CProveedorID.DataPropertyName = "ProveedorID";
            this.CProveedorID.HeaderText = "Cod.Proveedor";
            this.CProveedorID.MinimumWidth = 8;
            this.CProveedorID.Name = "CProveedorID";
            this.CProveedorID.ReadOnly = true;
            this.CProveedorID.Width = 190;
            // 
            // CProveedorNombre
            // 
            this.CProveedorNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.CProveedorNombre.HeaderText = "Nombre";
            this.CProveedorNombre.MinimumWidth = 8;
            this.CProveedorNombre.Name = "CProveedorNombre";
            this.CProveedorNombre.ReadOnly = true;
            // 
            // CProveedorCedula
            // 
            this.CProveedorCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProveedorCedula.DataPropertyName = "ProveedorCedula";
            this.CProveedorCedula.HeaderText = "Cédula";
            this.CProveedorCedula.MinimumWidth = 8;
            this.CProveedorCedula.Name = "CProveedorCedula";
            this.CProveedorCedula.ReadOnly = true;
            this.CProveedorCedula.Width = 230;
            // 
            // CProveedorCorreo
            // 
            this.CProveedorCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProveedorCorreo.DataPropertyName = "ProveedorCorreo";
            this.CProveedorCorreo.HeaderText = "Correo";
            this.CProveedorCorreo.MinimumWidth = 8;
            this.CProveedorCorreo.Name = "CProveedorCorreo";
            this.CProveedorCorreo.ReadOnly = true;
            this.CProveedorCorreo.Width = 400;
            // 
            // CTipoProveedorDescripcion
            // 
            this.CTipoProveedorDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTipoProveedorDescripcion.DataPropertyName = "TipoProveedorDescripcion";
            this.CTipoProveedorDescripcion.HeaderText = "Tipo Proveedor";
            this.CTipoProveedorDescripcion.MinimumWidth = 8;
            this.CTipoProveedorDescripcion.Name = "CTipoProveedorDescripcion";
            this.CTipoProveedorDescripcion.ReadOnly = true;
            this.CTipoProveedorDescripcion.Width = 160;
            // 
            // FrmProveedoresGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 694);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscarProveedor);
            this.Controls.Add(this.LblBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmProveedoresGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedoresGestion";
            this.Load += new System.EventHandler(this.FrmProveedoresGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.TextBox TxtBuscarProveedor;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.ComboBox CbTipoProveedor;
        private System.Windows.Forms.TextBox TxtProveedorCorreo;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtProveedorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedorCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoProveedorDescripcion;
    }
}