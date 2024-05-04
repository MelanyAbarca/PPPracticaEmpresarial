namespace PPPracticaEmpresarial.Formularios
{
    partial class FrmComprasRptListarPorFechas
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
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnVerReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(210, 70);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(359, 26);
            this.DtpFechaInicio.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(219, 150);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(350, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // BtnVerReporte
            // 
            this.BtnVerReporte.Location = new System.Drawing.Point(518, 279);
            this.BtnVerReporte.Name = "BtnVerReporte";
            this.BtnVerReporte.Size = new System.Drawing.Size(121, 34);
            this.BtnVerReporte.TabIndex = 2;
            this.BtnVerReporte.Text = "Ver Reporte";
            this.BtnVerReporte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FrmComprasRptListarPorFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVerReporte);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.DtpFechaInicio);
            this.Name = "FrmComprasRptListarPorFechas";
            this.Text = "FrmComprasRptListarPorFechas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnVerReporte;
        private System.Windows.Forms.Label label1;
    }
}