namespace Conservatorio.UI.Forms
{
    partial class V_Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Ingresos));
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.cbxPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.rbtnMes = new System.Windows.Forms.RadioButton();
            this.rbtnPeriodo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxAno
            // 
            this.tbxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(90, 100);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(55, 22);
            this.tbxAno.TabIndex = 3;
            this.tbxAno.Text = "0";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(22, 106);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(32, 16);
            this.lblAno.TabIndex = 64;
            this.lblAno.Text = "Año";
            // 
            // cbxMes
            // 
            this.cbxMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Location = new System.Drawing.Point(90, 142);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(121, 24);
            this.cbxMes.TabIndex = 4;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(22, 150);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(34, 16);
            this.lblMes.TabIndex = 62;
            this.lblMes.Text = "Mes";
            // 
            // cbxPeriodo
            // 
            this.cbxPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriodo.FormattingEnabled = true;
            this.cbxPeriodo.Location = new System.Drawing.Point(90, 180);
            this.cbxPeriodo.Name = "cbxPeriodo";
            this.cbxPeriodo.Size = new System.Drawing.Size(72, 24);
            this.cbxPeriodo.TabIndex = 5;
            this.cbxPeriodo.Visible = false;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(22, 188);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(56, 16);
            this.lblPeriodo.TabIndex = 67;
            this.lblPeriodo.Text = "Periodo";
            this.lblPeriodo.Visible = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.Image")));
            this.btnGenerarReporte.Location = new System.Drawing.Point(287, 142);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(90, 85);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // rbtnMes
            // 
            this.rbtnMes.AutoSize = true;
            this.rbtnMes.Checked = true;
            this.rbtnMes.Location = new System.Drawing.Point(34, 21);
            this.rbtnMes.Name = "rbtnMes";
            this.rbtnMes.Size = new System.Drawing.Size(45, 17);
            this.rbtnMes.TabIndex = 1;
            this.rbtnMes.TabStop = true;
            this.rbtnMes.Text = "Mes";
            this.rbtnMes.UseVisualStyleBackColor = true;
            this.rbtnMes.CheckedChanged += new System.EventHandler(this.rbtnMes_CheckedChanged);
            // 
            // rbtnPeriodo
            // 
            this.rbtnPeriodo.AutoSize = true;
            this.rbtnPeriodo.Location = new System.Drawing.Point(149, 21);
            this.rbtnPeriodo.Name = "rbtnPeriodo";
            this.rbtnPeriodo.Size = new System.Drawing.Size(61, 17);
            this.rbtnPeriodo.TabIndex = 2;
            this.rbtnPeriodo.Text = "Periodo";
            this.rbtnPeriodo.UseVisualStyleBackColor = true;
            this.rbtnPeriodo.CheckedChanged += new System.EventHandler(this.rbtnPeriodo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbtnMes);
            this.panel1.Controls.Add(this.rbtnPeriodo);
            this.panel1.Location = new System.Drawing.Point(125, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 58);
            this.panel1.TabIndex = 71;
            // 
            // V_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cbxPeriodo);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.lblMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.V_Ingresos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cbxPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.RadioButton rbtnMes;
        private System.Windows.Forms.RadioButton rbtnPeriodo;
        private System.Windows.Forms.Panel panel1;
    }
}