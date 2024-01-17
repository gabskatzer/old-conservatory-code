namespace Conservatorio.UI.Forms
{
    partial class V_Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Matricula));
            this.tbxBuscarEstudiante = new System.Windows.Forms.TextBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clbInstrumentos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.tbxMonto = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.tbxComentario = new System.Windows.Forms.TextBox();
            this.pbxEstudiante = new System.Windows.Forms.PictureBox();
            this.lblTipoEstudiante = new System.Windows.Forms.Label();
            this.tbxReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBuscarEstudiante
            // 
            this.tbxBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarEstudiante.Location = new System.Drawing.Point(60, 25);
            this.tbxBuscarEstudiante.Name = "tbxBuscarEstudiante";
            this.tbxBuscarEstudiante.Size = new System.Drawing.Size(231, 22);
            this.tbxBuscarEstudiante.TabIndex = 1;
            this.tbxBuscarEstudiante.TextChanged += new System.EventHandler(this.tbxBuscarEst_Matric_TextChanged);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(11, 59);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(406, 135);
            this.dgvEstudiantes.TabIndex = 2;
            this.dgvEstudiantes.DoubleClick += new System.EventHandler(this.dgvEst_Matric_DoubleClick);
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstudiante.Location = new System.Drawing.Point(437, 74);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(71, 20);
            this.lblNombreEstudiante.TabIndex = 3;
            this.lblNombreEstudiante.Text = "Nombre";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(737, 442);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 70);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvarMatricula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // clbInstrumentos
            // 
            this.clbInstrumentos.CheckOnClick = true;
            this.clbInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbInstrumentos.FormattingEnabled = true;
            this.clbInstrumentos.Location = new System.Drawing.Point(11, 239);
            this.clbInstrumentos.Name = "clbInstrumentos";
            this.clbInstrumentos.Size = new System.Drawing.Size(264, 123);
            this.clbInstrumentos.TabIndex = 3;
            this.clbInstrumentos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbInstrumentos_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Instrumentos";
            // 
            // dgvClases
            // 
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Location = new System.Drawing.Point(345, 239);
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.Size = new System.Drawing.Size(498, 123);
            this.dgvClases.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Clases";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(14, 392);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(103, 16);
            this.lblTipoPago.TabIndex = 22;
            this.lblTipoPago.Text = "Tipo de Pago";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(635, 392);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 16);
            this.lblMonto.TabIndex = 23;
            this.lblMonto.Text = "Monto";
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoPago.FormattingEnabled = true;
            this.cbxTipoPago.Location = new System.Drawing.Point(123, 389);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(121, 24);
            this.cbxTipoPago.TabIndex = 5;
            // 
            // tbxMonto
            // 
            this.tbxMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMonto.Location = new System.Drawing.Point(691, 389);
            this.tbxMonto.Name = "tbxMonto";
            this.tbxMonto.Size = new System.Drawing.Size(127, 22);
            this.tbxMonto.TabIndex = 7;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(13, 423);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(95, 16);
            this.lblComentario.TabIndex = 26;
            this.lblComentario.Text = "Comentarios";
            // 
            // tbxComentario
            // 
            this.tbxComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComentario.Location = new System.Drawing.Point(16, 442);
            this.tbxComentario.Multiline = true;
            this.tbxComentario.Name = "tbxComentario";
            this.tbxComentario.Size = new System.Drawing.Size(430, 69);
            this.tbxComentario.TabIndex = 8;
            // 
            // pbxEstudiante
            // 
            this.pbxEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxEstudiante.Location = new System.Drawing.Point(723, 57);
            this.pbxEstudiante.Name = "pbxEstudiante";
            this.pbxEstudiante.Size = new System.Drawing.Size(120, 137);
            this.pbxEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxEstudiante.TabIndex = 28;
            this.pbxEstudiante.TabStop = false;
            // 
            // lblTipoEstudiante
            // 
            this.lblTipoEstudiante.AutoSize = true;
            this.lblTipoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEstudiante.Location = new System.Drawing.Point(437, 107);
            this.lblTipoEstudiante.Name = "lblTipoEstudiante";
            this.lblTipoEstudiante.Size = new System.Drawing.Size(43, 20);
            this.lblTipoEstudiante.TabIndex = 29;
            this.lblTipoEstudiante.Text = "Tipo";
            // 
            // tbxReferencia
            // 
            this.tbxReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReferencia.Location = new System.Drawing.Point(413, 389);
            this.tbxReferencia.Name = "tbxReferencia";
            this.tbxReferencia.Size = new System.Drawing.Size(149, 22);
            this.tbxReferencia.TabIndex = 6;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(295, 392);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(112, 16);
            this.lblReferencia.TabIndex = 31;
            this.lblReferencia.Text = "No. Referencia";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(438, 25);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(63, 16);
            this.lblPeriodo.TabIndex = 32;
            this.lblPeriodo.Text = "Período";
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(507, 22);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(72, 24);
            this.cbxPeriodo.TabIndex = 3;
            this.cbxPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodo_SelectedIndexChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(635, 25);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 16);
            this.lblAno.TabIndex = 34;
            this.lblAno.Text = "Año";
            // 
            // tbxAno
            // 
            this.tbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(676, 22);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(92, 22);
            this.tbxAno.TabIndex = 4;
            this.tbxAno.TextChanged += new System.EventHandler(this.tbxAno_TextChanged);
            // 
            // V_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(868, 530);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.tbxReferencia);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.lblTipoEstudiante);
            this.Controls.Add(this.pbxEstudiante);
            this.Controls.Add(this.tbxComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.tbxMonto);
            this.Controls.Add(this.cbxTipoPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbInstrumentos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblNombreEstudiante);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.tbxBuscarEstudiante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_Matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.V_Matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxBuscarEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox clbInstrumentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.TextBox tbxMonto;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox tbxComentario;
        private System.Windows.Forms.PictureBox pbxEstudiante;
        private System.Windows.Forms.Label lblTipoEstudiante;
        private System.Windows.Forms.TextBox tbxReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
    }
}