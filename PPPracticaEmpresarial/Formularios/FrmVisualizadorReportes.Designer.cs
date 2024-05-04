namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmVisualizadorReportes
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
            this.CrvComprasVisualizador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CompraV21 = new PPPracticaEmpresarial.Reportes.CompraV2();
            this.SuspendLayout();
            // 
            // CrvComprasVisualizador
            // 
            this.CrvComprasVisualizador.ActiveViewIndex = -1;
            this.CrvComprasVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvComprasVisualizador.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvComprasVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvComprasVisualizador.Location = new System.Drawing.Point(0, 0);
            this.CrvComprasVisualizador.Name = "CrvComprasVisualizador";
            this.CrvComprasVisualizador.Size = new System.Drawing.Size(1102, 611);
            this.CrvComprasVisualizador.TabIndex = 0;
            this.CrvComprasVisualizador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmComprasVisualizadorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 611);
            this.Controls.Add(this.CrvComprasVisualizador);
            this.Name = "FrmComprasVisualizadorReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrvComprasVisualizador;
        private Reportes.CompraV2 CompraV21;
    }
}