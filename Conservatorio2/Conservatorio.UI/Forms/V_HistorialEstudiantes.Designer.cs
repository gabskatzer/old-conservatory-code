namespace Conservatorio.UI.Forms
{
    partial class V_HistorialEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HistorialEstudiantes));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxBuscarEstudiantes = new System.Windows.Forms.TextBox();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblInactivo = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // tbxBuscarEstudiantes
            // 
            this.tbxBuscarEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarEstudiantes.Location = new System.Drawing.Point(156, 30);
            this.tbxBuscarEstudiantes.Name = "tbxBuscarEstudiantes";
            this.tbxBuscarEstudiantes.Size = new System.Drawing.Size(273, 22);
            this.tbxBuscarEstudiantes.TabIndex = 1;
            this.tbxBuscarEstudiantes.TextChanged += new System.EventHandler(this.tbxBuscarEstudiantes_TextChanged);
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantes.Location = new System.Drawing.Point(20, 30);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(89, 16);
            this.lblEstudiantes.TabIndex = 64;
            this.lblEstudiantes.Text = "Estudiantes";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(23, 58);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(406, 135);
            this.dgvEstudiantes.TabIndex = 2;
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.Location = new System.Drawing.Point(3, 19);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(63, 16);
            this.lblActivos.TabIndex = 67;
            this.lblActivos.Text = "Activos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(113, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Inactivos:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTotales);
            this.panel1.Controls.Add(this.lblInactivo);
            this.panel1.Controls.Add(this.lblActivo);
            this.panel1.Controls.Add(this.lblActivos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(459, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 122);
            this.panel1.TabIndex = 70;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotales.Location = new System.Drawing.Point(3, 87);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(48, 16);
            this.lblTotales.TabIndex = 72;
            this.lblTotales.Text = "Total:";
            // 
            // lblInactivo
            // 
            this.lblInactivo.AutoSize = true;
            this.lblInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivo.Location = new System.Drawing.Point(113, 48);
            this.lblInactivo.Name = "lblInactivo";
            this.lblInactivo.Size = new System.Drawing.Size(89, 16);
            this.lblInactivo.TabIndex = 71;
            this.lblInactivo.Text = "Estudiantes";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(113, 19);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(89, 16);
            this.lblActivo.TabIndex = 70;
            this.lblActivo.Text = "Estudiantes";
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarNota.Image")));
            this.btnSalvarNota.Location = new System.Drawing.Point(327, 219);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(88, 84);
            this.btnSalvarNota.TabIndex = 3;
            this.btnSalvarNota.Text = "Generar Reporte";
            this.btnSalvarNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarNota.UseVisualStyleBackColor = true;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // V_HistorialEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 338);
            this.Controls.Add(this.btnSalvarNota);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxBuscarEstudiantes);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.dgvEstudiantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_HistorialEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Estudiantes";
            this.Load += new System.EventHandler(this.V_HistorialEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxBuscarEstudiantes;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInactivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.Label lblTotales;
    }
}