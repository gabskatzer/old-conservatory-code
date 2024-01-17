namespace Conservatorio.UI.Forms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.miMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.miEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstrumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.miCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.miClases = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegistroNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.miFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.miMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.miMensualidad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miMantenimiento
            // 
            this.miMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEstudiantes,
            this.miProfesores,
            this.miInstrumentos,
            this.miCursos,
            this.miClases,
            this.miRegistroNotas});
            this.miMantenimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miMantenimiento.Name = "miMantenimiento";
            this.miMantenimiento.Size = new System.Drawing.Size(115, 23);
            this.miMantenimiento.Text = "Mantenimiento";
            // 
            // miEstudiantes
            // 
            this.miEstudiantes.Name = "miEstudiantes";
            this.miEstudiantes.Size = new System.Drawing.Size(187, 24);
            this.miEstudiantes.Text = "Estudiantes";
            this.miEstudiantes.Click += new System.EventHandler(this.miEstudiantes_Click);
            // 
            // miProfesores
            // 
            this.miProfesores.Name = "miProfesores";
            this.miProfesores.Size = new System.Drawing.Size(187, 24);
            this.miProfesores.Text = "Profesores";
            this.miProfesores.Click += new System.EventHandler(this.miProfesores_Click);
            // 
            // miInstrumentos
            // 
            this.miInstrumentos.Name = "miInstrumentos";
            this.miInstrumentos.Size = new System.Drawing.Size(187, 24);
            this.miInstrumentos.Text = "Instrumentos";
            this.miInstrumentos.Click += new System.EventHandler(this.miInstrumentos_Click);
            // 
            // miCursos
            // 
            this.miCursos.Name = "miCursos";
            this.miCursos.Size = new System.Drawing.Size(187, 24);
            this.miCursos.Text = "Cursos";
            this.miCursos.Click += new System.EventHandler(this.miCursos_Click);
            // 
            // miClases
            // 
            this.miClases.Name = "miClases";
            this.miClases.Size = new System.Drawing.Size(187, 24);
            this.miClases.Text = "Clases";
            this.miClases.Click += new System.EventHandler(this.miClases_Click);
            // 
            // miRegistroNotas
            // 
            this.miRegistroNotas.Name = "miRegistroNotas";
            this.miRegistroNotas.Size = new System.Drawing.Size(187, 24);
            this.miRegistroNotas.Text = "Registro de Notas";
            this.miRegistroNotas.Click += new System.EventHandler(this.miRegistroNotas_Click);
            // 
            // miFacturacion
            // 
            this.miFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMatricula,
            this.miMensualidad});
            this.miFacturacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miFacturacion.Name = "miFacturacion";
            this.miFacturacion.Size = new System.Drawing.Size(91, 23);
            this.miFacturacion.Text = "Facturación";
            // 
            // miMatricula
            // 
            this.miMatricula.Name = "miMatricula";
            this.miMatricula.Size = new System.Drawing.Size(156, 24);
            this.miMatricula.Text = "Matricula";
            this.miMatricula.Click += new System.EventHandler(this.miMatricula_Click);
            // 
            // miMensualidad
            // 
            this.miMensualidad.Name = "miMensualidad";
            this.miMensualidad.Size = new System.Drawing.Size(156, 24);
            this.miMensualidad.Text = "Mensualidad";
            this.miMensualidad.Click += new System.EventHandler(this.miMensualidad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMantenimiento,
            this.miFacturacion,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.IngresosToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.estudiantesToolStripMenuItem.Text = "Historial Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // IngresosToolStripMenuItem
            // 
            this.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem";
            this.IngresosToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.IngresosToolStripMenuItem.Text = "Ingresos";
            this.IngresosToolStripMenuItem.Click += new System.EventHandler(this.IngresosToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 619);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem miMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem miEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem miProfesores;
        private System.Windows.Forms.ToolStripMenuItem miInstrumentos;
        private System.Windows.Forms.ToolStripMenuItem miCursos;
        private System.Windows.Forms.ToolStripMenuItem miClases;
        private System.Windows.Forms.ToolStripMenuItem miRegistroNotas;
        private System.Windows.Forms.ToolStripMenuItem miFacturacion;
        private System.Windows.Forms.ToolStripMenuItem miMatricula;
        private System.Windows.Forms.ToolStripMenuItem miMensualidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IngresosToolStripMenuItem;
    }
}