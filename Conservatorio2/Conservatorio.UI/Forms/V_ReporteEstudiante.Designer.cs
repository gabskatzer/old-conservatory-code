namespace Conservatorio.UI.Forms
{
    partial class V_ReporteEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ReporteEstudiante));
            this.obtenerReporteEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesDataSet = new Conservatorio.UI.Reportes.ReportesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.obtenerReporteEstudianteTableAdapter = new Conservatorio.UI.Reportes.ReportesDataSetTableAdapters.ObtenerReporteEstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteEstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // obtenerReporteEstudianteBindingSource
            // 
            this.obtenerReporteEstudianteBindingSource.DataMember = "ObtenerReporteEstudiante";
            this.obtenerReporteEstudianteBindingSource.DataSource = this.reportesDataSet;
            // 
            // reportesDataSet
            // 
            this.reportesDataSet.DataSetName = "ReportesDataSet";
            this.reportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReporteEstudianteDataSet";
            reportDataSource1.Value = this.obtenerReporteEstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Conservatorio.UI.Reportes.ReporteEstudiante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(742, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // obtenerReporteEstudianteTableAdapter
            // 
            this.obtenerReporteEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // V_ReporteEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 489);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_ReporteEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificación de notas";
            this.Load += new System.EventHandler(this.V_ReporteEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obtenerReporteEstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource obtenerReporteEstudianteBindingSource;
        private Reportes.ReportesDataSet reportesDataSet;
        private Reportes.ReportesDataSetTableAdapters.ObtenerReporteEstudianteTableAdapter obtenerReporteEstudianteTableAdapter;
    }
}