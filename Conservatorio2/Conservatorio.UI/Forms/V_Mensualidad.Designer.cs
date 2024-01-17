namespace Conservatorio.UI.Forms
{
    partial class V_Mensualidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Mensualidad));
            this.tbxReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblTipoEstudiante = new System.Windows.Forms.Label();
            this.pbxEstudiante = new System.Windows.Forms.PictureBox();
            this.tbxComentario = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.tbxMontoMens = new System.Windows.Forms.TextBox();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.lblMensualidad = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.btnSalvarMensualidad = new System.Windows.Forms.Button();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.dgvEst_Mensualidad = new System.Windows.Forms.DataGridView();
            this.tbxBuscarEst_Mensualidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalCol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxMulta = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst_Mensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxReferencia
            // 
            this.tbxReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReferencia.Location = new System.Drawing.Point(610, 207);
            this.tbxReferencia.Name = "tbxReferencia";
            this.tbxReferencia.Size = new System.Drawing.Size(149, 22);
            this.tbxReferencia.TabIndex = 5;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(497, 215);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(98, 16);
            this.lblReferencia.TabIndex = 49;
            this.lblReferencia.Text = "No. Referencia";
            // 
            // lblTipoEstudiante
            // 
            this.lblTipoEstudiante.AutoSize = true;
            this.lblTipoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEstudiante.Location = new System.Drawing.Point(426, 67);
            this.lblTipoEstudiante.Name = "lblTipoEstudiante";
            this.lblTipoEstudiante.Size = new System.Drawing.Size(43, 20);
            this.lblTipoEstudiante.TabIndex = 47;
            this.lblTipoEstudiante.Text = "Tipo";
            // 
            // pbxEstudiante
            // 
            this.pbxEstudiante.Location = new System.Drawing.Point(639, 18);
            this.pbxEstudiante.Name = "pbxEstudiante";
            this.pbxEstudiante.Size = new System.Drawing.Size(120, 137);
            this.pbxEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxEstudiante.TabIndex = 46;
            this.pbxEstudiante.TabStop = false;
            // 
            // tbxComentario
            // 
            this.tbxComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxComentario.Location = new System.Drawing.Point(18, 386);
            this.tbxComentario.Multiline = true;
            this.tbxComentario.Name = "tbxComentario";
            this.tbxComentario.Size = new System.Drawing.Size(430, 69);
            this.tbxComentario.TabIndex = 9;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(14, 350);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(84, 16);
            this.lblComentarios.TabIndex = 45;
            this.lblComentarios.Text = "Comentarios";
            // 
            // tbxMontoMens
            // 
            this.tbxMontoMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMontoMens.Location = new System.Drawing.Point(344, 288);
            this.tbxMontoMens.Name = "tbxMontoMens";
            this.tbxMontoMens.Size = new System.Drawing.Size(121, 22);
            this.tbxMontoMens.TabIndex = 8;
            this.tbxMontoMens.Text = "0";
            this.tbxMontoMens.TextChanged += new System.EventHandler(this.tbxMontoMens_TextChanged);
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoPago.FormattingEnabled = true;
            this.cbxTipoPago.Location = new System.Drawing.Point(344, 207);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(121, 24);
            this.cbxTipoPago.TabIndex = 4;
            // 
            // lblMensualidad
            // 
            this.lblMensualidad.AutoSize = true;
            this.lblMensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensualidad.Location = new System.Drawing.Point(251, 294);
            this.lblMensualidad.Name = "lblMensualidad";
            this.lblMensualidad.Size = new System.Drawing.Size(86, 16);
            this.lblMensualidad.TabIndex = 44;
            this.lblMensualidad.Text = "Mensualidad";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(247, 215);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(91, 16);
            this.lblTipoPago.TabIndex = 43;
            this.lblTipoPago.Text = "Tipo de Pago";
            // 
            // btnSalvarMensualidad
            // 
            this.btnSalvarMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarMensualidad.Image")));
            this.btnSalvarMensualidad.Location = new System.Drawing.Point(665, 381);
            this.btnSalvarMensualidad.Name = "btnSalvarMensualidad";
            this.btnSalvarMensualidad.Size = new System.Drawing.Size(70, 70);
            this.btnSalvarMensualidad.TabIndex = 10;
            this.btnSalvarMensualidad.Text = "Salvar";
            this.btnSalvarMensualidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarMensualidad.UseVisualStyleBackColor = true;
            this.btnSalvarMensualidad.Click += new System.EventHandler(this.btnSalvarMensualidad_Click);
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstudiante.Location = new System.Drawing.Point(426, 18);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(71, 20);
            this.lblNombreEstudiante.TabIndex = 34;
            this.lblNombreEstudiante.Text = "Nombre";
            // 
            // dgvEst_Mensualidad
            // 
            this.dgvEst_Mensualidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst_Mensualidad.Location = new System.Drawing.Point(14, 44);
            this.dgvEst_Mensualidad.Name = "dgvEst_Mensualidad";
            this.dgvEst_Mensualidad.Size = new System.Drawing.Size(406, 135);
            this.dgvEst_Mensualidad.TabIndex = 2;
            this.dgvEst_Mensualidad.DoubleClick += new System.EventHandler(this.dgvEst_Mensualidad_DoubleClick);
            // 
            // tbxBuscarEst_Mensualidad
            // 
            this.tbxBuscarEst_Mensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBuscarEst_Mensualidad.Location = new System.Drawing.Point(59, 16);
            this.tbxBuscarEst_Mensualidad.Name = "tbxBuscarEst_Mensualidad";
            this.tbxBuscarEst_Mensualidad.Size = new System.Drawing.Size(217, 22);
            this.tbxBuscarEst_Mensualidad.TabIndex = 1;
            this.tbxBuscarEst_Mensualidad.TextChanged += new System.EventHandler(this.tbxBuscarEst_Mensualidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Multa";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(12, 215);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 16);
            this.lblMes.TabIndex = 54;
            this.lblMes.Text = "Mes";
            // 
            // cbxMes
            // 
            this.cbxMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Location = new System.Drawing.Point(55, 207);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(121, 24);
            this.cbxMes.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Gran Total";
            // 
            // lblTotalCol
            // 
            this.lblTotalCol.AutoSize = true;
            this.lblTotalCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCol.Location = new System.Drawing.Point(607, 291);
            this.lblTotalCol.Name = "lblTotalCol";
            this.lblTotalCol.Size = new System.Drawing.Size(63, 16);
            this.lblTotalCol.TabIndex = 57;
            this.lblTotalCol.Text = "colones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // tbxMulta
            // 
            this.tbxMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMulta.Location = new System.Drawing.Point(55, 294);
            this.tbxMulta.Name = "tbxMulta";
            this.tbxMulta.Size = new System.Drawing.Size(127, 22);
            this.tbxMulta.TabIndex = 7;
            this.tbxMulta.Text = "0";
            this.tbxMulta.TextChanged += new System.EventHandler(this.tbxMulta_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // tbxAno
            // 
            this.tbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(56, 248);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(55, 22);
            this.tbxAno.TabIndex = 6;
            this.tbxAno.Text = "0";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(15, 254);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(32, 16);
            this.lblAno.TabIndex = 60;
            this.lblAno.Text = "Año";
            // 
            // V_Mensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(797, 482);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.tbxMulta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalCol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxReferencia);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.lblTipoEstudiante);
            this.Controls.Add(this.pbxEstudiante);
            this.Controls.Add(this.tbxComentario);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.tbxMontoMens);
            this.Controls.Add(this.cbxTipoPago);
            this.Controls.Add(this.lblMensualidad);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.btnSalvarMensualidad);
            this.Controls.Add(this.lblNombreEstudiante);
            this.Controls.Add(this.dgvEst_Mensualidad);
            this.Controls.Add(this.tbxBuscarEst_Mensualidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_Mensualidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Mensual";
            this.Load += new System.EventHandler(this.V_Mensualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst_Mensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblTipoEstudiante;
        private System.Windows.Forms.PictureBox pbxEstudiante;
        private System.Windows.Forms.TextBox tbxComentario;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox tbxMontoMens;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.Label lblMensualidad;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Button btnSalvarMensualidad;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.DataGridView dgvEst_Mensualidad;
        private System.Windows.Forms.TextBox tbxBuscarEst_Mensualidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalCol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxMulta;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Label lblAno;
    }
}