namespace CorPartReportes
{
    partial class FrmListado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnListado = new System.Windows.Forms.Button();
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.LblAnio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CorPartReportes.Listado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(803, 400);
            this.reportViewer1.TabIndex = 3;
            // 
            // BtnListado
            // 
            this.BtnListado.Location = new System.Drawing.Point(662, 12);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(126, 35);
            this.BtnListado.TabIndex = 2;
            this.BtnListado.Text = "Generar";
            this.BtnListado.UseVisualStyleBackColor = true;
            this.BtnListado.Click += new System.EventHandler(this.BtnListado_Click);
            // 
            // TxtAnio
            // 
            this.TxtAnio.Location = new System.Drawing.Point(294, 18);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(196, 22);
            this.TxtAnio.TabIndex = 1;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(40, 21);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(223, 16);
            this.LblAnio.TabIndex = 0;
            this.LblAnio.Text = "Ingrese el año que desea actualizar:";
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.TxtAnio);
            this.Controls.Add(this.BtnListado);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "FrmListado";
            this.Text = "Análisis de facturación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button BtnListado;
        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.Label LblAnio;
    }
}