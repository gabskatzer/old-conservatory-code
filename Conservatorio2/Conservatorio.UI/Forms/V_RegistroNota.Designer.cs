namespace Conservatorio.UI.Forms
{
    partial class V_RegistroNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RegistroNota));
            this.tbxNotaFinal = new System.Windows.Forms.TextBox();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.tbxBuscarClases = new System.Windows.Forms.TextBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNota = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxBuscarEstudiantes = new System.Windows.Forms.TextBox();
            this.lblClases = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            this.pnlNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNotaFinal
            // 
            this.tbxNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNotaFinal.Location = new System.Drawing.Point(137, 110);
            this.tbxNotaFinal.Name = "tbxNotaFinal";
            this.tbxNotaFinal.Size = new System.Drawing.Size(65, 30);
            this.tbxNotaFinal.TabIndex = 7;
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantes.Location = new System.Drawing.Point(35, 254);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(89, 16);
            this.lblEstudiantes.TabIndex = 42;
            this.lblEstudiantes.Text = "Estudiantes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarNota.Image")));
            this.btnSalvarNota.Location = new System.Drawing.Point(81, 163);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(70, 70);
            this.btnSalvarNota.TabIndex = 8;
            this.btnSalvarNota.Text = "Salvar";
            this.btnSalvarNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarNota.UseVisualStyleBackColor = true;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(38, 282);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(406, 135);
            this.dgvEstudiantes.TabIndex = 6;
            this.dgvEstudiantes.DoubleClick += new System.EventHandler(this.dgvEstudiantes_DoubleClick);
            // 
            // tbxBuscarClases
            // 
            this.tbxBuscarClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarClases.Location = new System.Drawing.Point(184, 65);
            this.tbxBuscarClases.Name = "tbxBuscarClases";
            this.tbxBuscarClases.Size = new System.Drawing.Size(258, 22);
            this.tbxBuscarClases.TabIndex = 3;
            this.tbxBuscarClases.TextChanged += new System.EventHandler(this.tbxBuscarClases_TextChanged);
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinal.Location = new System.Drawing.Point(3, 117);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(91, 20);
            this.lblNotaFinal.TabIndex = 52;
            this.lblNotaFinal.Text = "Nota Final";
            // 
            // dgvClases
            // 
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Location = new System.Drawing.Point(38, 95);
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.Size = new System.Drawing.Size(406, 135);
            this.dgvClases.TabIndex = 4;
            this.dgvClases.DoubleClick += new System.EventHandler(this.dgvClases_DoubleClick);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(4, 19);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(48, 16);
            this.lblCurso.TabIndex = 54;
            this.lblCurso.Text = "Curso";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(4, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 16);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Estudiante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Periodo";
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(367, 24);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(77, 21);
            this.cbxPeriodo.TabIndex = 1;
            this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Año";
            // 
            // pnlNota
            // 
            this.pnlNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNota.Controls.Add(this.lblCurso);
            this.pnlNota.Controls.Add(this.lblNombre);
            this.pnlNota.Controls.Add(this.lblNotaFinal);
            this.pnlNota.Controls.Add(this.tbxNotaFinal);
            this.pnlNota.Controls.Add(this.btnSalvarNota);
            this.pnlNota.Location = new System.Drawing.Point(476, 118);
            this.pnlNota.Name = "pnlNota";
            this.pnlNota.Size = new System.Drawing.Size(238, 252);
            this.pnlNota.TabIndex = 60;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(130, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // tbxBuscarEstudiantes
            // 
            this.tbxBuscarEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarEstudiantes.Location = new System.Drawing.Point(171, 254);
            this.tbxBuscarEstudiantes.Name = "tbxBuscarEstudiantes";
            this.tbxBuscarEstudiantes.Size = new System.Drawing.Size(273, 22);
            this.tbxBuscarEstudiantes.TabIndex = 5;
            this.tbxBuscarEstudiantes.TextChanged += new System.EventHandler(this.tbxBuscarEstudiantes_TextChanged);
            // 
            // lblClases
            // 
            this.lblClases.AutoSize = true;
            this.lblClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClases.Location = new System.Drawing.Point(35, 65);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(56, 16);
            this.lblClases.TabIndex = 63;
            this.lblClases.Text = "Clases";
            // 
            // tbxAno
            // 
            this.tbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(534, 24);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(61, 22);
            this.tbxAno.TabIndex = 64;
            this.tbxAno.TextChanged += new System.EventHandler(this.tbxAno_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // V_RegistroNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.lblClases);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxBuscarEstudiantes);
            this.Controls.Add(this.pnlNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClases);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.tbxBuscarClases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_RegistroNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Notas";
            this.Load += new System.EventHandler(this.V_RegistroNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            this.pnlNota.ResumeLayout(false);
            this.pnlNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxNotaFinal;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox tbxBuscarClases;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNota;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxBuscarEstudiantes;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}