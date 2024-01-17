namespace Conservatorio.UI.Forms
{
    partial class V_AgregarModificarClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarModificarClase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.cbxProfesores = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.cbxInstrumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAula = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(15, 75);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(46, 16);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(15, 120);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(62, 16);
            this.lblProfesor.TabIndex = 1;
            this.lblProfesor.Text = "Profesor:";
            // 
            // cbxCursos
            // 
            this.cbxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(100, 72);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(222, 24);
            this.cbxCursos.TabIndex = 3;
            // 
            // cbxProfesores
            // 
            this.cbxProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfesores.FormattingEnabled = true;
            this.cbxProfesores.Location = new System.Drawing.Point(94, 117);
            this.cbxProfesores.Name = "cbxProfesores";
            this.cbxProfesores.Size = new System.Drawing.Size(228, 24);
            this.cbxProfesores.TabIndex = 5;
            this.cbxProfesores.SelectedIndexChanged += new System.EventHandler(this.cbxProfesores_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(326, 440);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.Location = new System.Drawing.Point(15, 30);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(79, 16);
            this.lblInstrumento.TabIndex = 13;
            this.lblInstrumento.Text = "Instrumento:";
            // 
            // cbxInstrumento
            // 
            this.cbxInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInstrumento.FormattingEnabled = true;
            this.cbxInstrumento.Location = new System.Drawing.Point(100, 27);
            this.cbxInstrumento.Name = "cbxInstrumento";
            this.cbxInstrumento.Size = new System.Drawing.Size(222, 24);
            this.cbxInstrumento.TabIndex = 1;
            this.cbxInstrumento.SelectedIndexChanged += new System.EventHandler(this.cbxInstrumento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aula:";
            // 
            // tbxAula
            // 
            this.tbxAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAula.Location = new System.Drawing.Point(476, 114);
            this.tbxAula.Name = "tbxAula";
            this.tbxAula.Size = new System.Drawing.Size(80, 22);
            this.tbxAula.TabIndex = 6;
            this.tbxAula.TextChanged += new System.EventHandler(this.tbxAula_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(435, 30);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(59, 16);
            this.lblPeriodo.TabIndex = 17;
            this.lblPeriodo.Text = "Período:";
            // 
            // tbxAno
            // 
            this.tbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(476, 72);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(80, 22);
            this.tbxAno.TabIndex = 4;
            this.tbxAno.TextChanged += new System.EventHandler(this.tbxAno_TextChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(435, 75);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 16);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Año:";
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(500, 27);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(56, 24);
            this.cbxPeriodo.TabIndex = 2;
            this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHorario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorario.Location = new System.Drawing.Point(12, 170);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersVisible = false;
            this.dgvHorario.Size = new System.Drawing.Size(678, 251);
            this.dgvHorario.TabIndex = 7;
            // 
            // V_AgregarModificarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(721, 522);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.tbxAula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxProfesores);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_AgregarModificarClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Clase";
            this.Load += new System.EventHandler(this.V_AgregarModificarClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.ComboBox cbxProfesores;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.ComboBox cbxInstrumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAula;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.DataGridView dgvHorario;
    }
}