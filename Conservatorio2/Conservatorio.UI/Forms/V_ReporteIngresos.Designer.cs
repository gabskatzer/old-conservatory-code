namespace Conservatorio.UI.Forms
{
    partial class V_ReporteIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ReporteIngresos));
            this.obtenerReporteIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesDataSet = new Conservatorio.UI.Reportes.ReportesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.obtenerReporteIngresosTableAdapter = new Conservatorio.UI.Reportes.ReportesDataSetTableAdapters.ObtenerReporteIngresosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteIngresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // obtenerReporteIngresosBindingSource
            // 
            this.obtenerReporteIngresosBindingSource.DataMember = "ObtenerReporteIngresos";
            this.obtenerReporteIngresosBindingSource.DataSource = this.reportesDataSet;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReporteIngresosDataSet";
            reportDataSource1.Value = this.obtenerReporteIngresosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Conservatorio.UI.Reportes.ReporteIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // obtenerReporteIngresosTableAdapter
            // 
            this.obtenerReporteIngresosTableAdapter.ClearBeforeFill = true;
            // 
            // V_ReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 575);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_ReporteIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ingresos";
            this.Load += new System.EventHandler(this.V_ReporteIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteIngresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obtenerReporteIngresosBindingSource;
        private Reportes.ReportesDataSet reportesDataSet;
        private Reportes.ReportesDataSetTableAdapters.ObtenerReporteIngresosTableAdapter obtenerReporteIngresosTableAdapter;
    }
}