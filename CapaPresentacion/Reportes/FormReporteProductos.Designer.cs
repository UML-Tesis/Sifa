namespace CapaPresentacion
{
    partial class FormReporteProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spMostrarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spMostrarProductosTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spMostrarProductosTableAdapter();
            this.spReporteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReporteFacturaTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spReporteFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spMostrarProductosBindingSource
            // 
            this.spMostrarProductosBindingSource.DataMember = "spMostrarProductos";
            this.spMostrarProductosBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spMostrarProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(920, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // spMostrarProductosTableAdapter
            // 
            this.spMostrarProductosTableAdapter.ClearBeforeFill = true;
            // 
            // spReporteFacturaBindingSource
            // 
            this.spReporteFacturaBindingSource.DataMember = "spReporteFactura";
            this.spReporteFacturaBindingSource.DataSource = this.dsPrincipal;
            // 
            // spReporteFacturaTableAdapter
            // 
            this.spReporteFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 392);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteProductos";
            this.Text = "FormReporteProductos";
            this.Load += new System.EventHandler(this.FormReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spMostrarProductosBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spMostrarProductosTableAdapter spMostrarProductosTableAdapter;
        private System.Windows.Forms.BindingSource spReporteFacturaBindingSource;
        private dsPrincipalTableAdapters.spReporteFacturaTableAdapter spReporteFacturaTableAdapter;
    }
}