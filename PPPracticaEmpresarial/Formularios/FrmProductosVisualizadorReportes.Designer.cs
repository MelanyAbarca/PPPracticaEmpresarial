namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmProductosVisualizadorReportes
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
            this.CrvProductosVisualizador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ProductosV21 = new PPPracticaEmpresarial.Reportes.ProductosV2();
            this.SuspendLayout();
            // 
            // CrvProductosVisualizador
            // 
            this.CrvProductosVisualizador.ActiveViewIndex = -1;
            this.CrvProductosVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvProductosVisualizador.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvProductosVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvProductosVisualizador.Location = new System.Drawing.Point(0, 0);
            this.CrvProductosVisualizador.Name = "CrvProductosVisualizador";
            this.CrvProductosVisualizador.ReportSource = this.ProductosV21;
            this.CrvProductosVisualizador.Size = new System.Drawing.Size(1136, 488);
            this.CrvProductosVisualizador.TabIndex = 0;
            this.CrvProductosVisualizador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmProductosVisualizadorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 488);
            this.Controls.Add(this.CrvProductosVisualizador);
            this.Name = "FrmProductosVisualizadorReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrvProductosVisualizador;
        private Reportes.ProductosV2 ProductosV21;
    }
}