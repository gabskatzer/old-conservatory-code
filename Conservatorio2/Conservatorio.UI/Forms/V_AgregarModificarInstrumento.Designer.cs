namespace Conservatorio.UI.Forms
{
    partial class V_AgregarModificarInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarModificarInstrumento));
            this.btnAgregarInst = new System.Windows.Forms.Button();
            this.lblNombreInst = new System.Windows.Forms.Label();
            this.tbxNombreInst = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbtnIndividual = new System.Windows.Forms.RadioButton();
            this.rbtnGrupal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarInst
            // 
            this.btnAgregarInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInst.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInst.Image")));
            this.btnAgregarInst.Location = new System.Drawing.Point(168, 156);
            this.btnAgregarInst.Name = "btnAgregarInst";
            this.btnAgregarInst.Size = new System.Drawing.Size(70, 70);
            this.btnAgregarInst.TabIndex = 4;
            this.btnAgregarInst.Text = "Salvar";
            this.btnAgregarInst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarInst.UseVisualStyleBackColor = true;
            this.btnAgregarInst.Click += new System.EventHandler(this.btnAgregarInst_Click);
            // 
            // lblNombreInst
            // 
            this.lblNombreInst.AutoSize = true;
            this.lblNombreInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInst.Location = new System.Drawing.Point(61, 50);
            this.lblNombreInst.Name = "lblNombreInst";
            this.lblNombreInst.Size = new System.Drawing.Size(60, 16);
            this.lblNombreInst.TabIndex = 2;
            this.lblNombreInst.Text = "Nombre:";
            // 
            // tbxNombreInst
            // 
            this.tbxNombreInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombreInst.Location = new System.Drawing.Point(136, 50);
            this.tbxNombreInst.Name = "tbxNombreInst";
            this.tbxNombreInst.Size = new System.Drawing.Size(198, 22);
            this.tbxNombreInst.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // rbtnIndividual
            // 
            this.rbtnIndividual.AutoSize = true;
            this.rbtnIndividual.Checked = true;
            this.rbtnIndividual.Location = new System.Drawing.Point(64, 107);
            this.rbtnIndividual.Name = "rbtnIndividual";
            this.rbtnIndividual.Size = new System.Drawing.Size(70, 17);
            this.rbtnIndividual.TabIndex = 2;
            this.rbtnIndividual.TabStop = true;
            this.rbtnIndividual.Text = "Individual";
            this.rbtnIndividual.UseVisualStyleBackColor = true;
            // 
            // rbtnGrupal
            // 
            this.rbtnGrupal.AutoSize = true;
            this.rbtnGrupal.Location = new System.Drawing.Point(278, 107);
            this.rbtnGrupal.Name = "rbtnGrupal";
            this.rbtnGrupal.Size = new System.Drawing.Size(56, 17);
            this.rbtnGrupal.TabIndex = 3;
            this.rbtnGrupal.Text = "Grupal";
            this.rbtnGrupal.UseVisualStyleBackColor = true;
            // 
            // V_AgregarModificarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(403, 265);
            this.Controls.Add(this.rbtnGrupal);
            this.Controls.Add(this.rbtnIndividual);
            this.Controls.Add(this.tbxNombreInst);
            this.Controls.Add(this.lblNombreInst);
            this.Controls.Add(this.btnAgregarInst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_AgregarModificarInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Instrumento";
            this.Load += new System.EventHandler(this.V_AgregarModificarInstrumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarInst;
        private System.Windows.Forms.Label lblNombreInst;
        private System.Windows.Forms.TextBox tbxNombreInst;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton rbtnGrupal;
        private System.Windows.Forms.RadioButton rbtnIndividual;
    }
}