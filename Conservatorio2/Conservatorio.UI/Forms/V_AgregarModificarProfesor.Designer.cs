using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    partial class V_AgregarModificarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarModificarProfesor));
            this.btnAgregarProf = new System.Windows.Forms.Button();
            this.tbxTelefono3 = new System.Windows.Forms.TextBox();
            this.tbxTelefono2 = new System.Windows.Forms.TextBox();
            this.tbxTelefono1 = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxOcupacion = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxCedula = new System.Windows.Forms.TextBox();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.lblTelefono3 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInstrumentos = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.clbInstrumentos = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCapturar = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProf
            // 
            this.btnAgregarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProf.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProf.Image")));
            this.btnAgregarProf.Location = new System.Drawing.Point(657, 422);
            this.btnAgregarProf.Name = "btnAgregarProf";
            this.btnAgregarProf.Size = new System.Drawing.Size(70, 70);
            this.btnAgregarProf.TabIndex = 15;
            this.btnAgregarProf.Text = "Salvar";
            this.btnAgregarProf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProf.UseVisualStyleBackColor = true;
            this.btnAgregarProf.Click += new System.EventHandler(this.btnAgregarProf_Click);
            // 
            // tbxTelefono3
            // 
            this.tbxTelefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono3.Location = new System.Drawing.Point(91, 341);
            this.tbxTelefono3.Name = "tbxTelefono3";
            this.tbxTelefono3.Size = new System.Drawing.Size(166, 22);
            this.tbxTelefono3.TabIndex = 10;
            // 
            // tbxTelefono2
            // 
            this.tbxTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono2.Location = new System.Drawing.Point(91, 300);
            this.tbxTelefono2.Name = "tbxTelefono2";
            this.tbxTelefono2.Size = new System.Drawing.Size(166, 22);
            this.tbxTelefono2.TabIndex = 9;
            // 
            // tbxTelefono1
            // 
            this.tbxTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono1.Location = new System.Drawing.Point(91, 260);
            this.tbxTelefono1.Name = "tbxTelefono1";
            this.tbxTelefono1.Size = new System.Drawing.Size(166, 22);
            this.tbxTelefono1.TabIndex = 8;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(61, 210);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(210, 22);
            this.tbxEmail.TabIndex = 7;
            // 
            // tbxOcupacion
            // 
            this.tbxOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOcupacion.Location = new System.Drawing.Point(92, 160);
            this.tbxOcupacion.Name = "tbxOcupacion";
            this.tbxOcupacion.Size = new System.Drawing.Size(275, 22);
            this.tbxOcupacion.TabIndex = 6;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDireccion.Location = new System.Drawing.Point(84, 389);
            this.tbxDireccion.Multiline = true;
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(283, 82);
            this.tbxDireccion.TabIndex = 11;
            // 
            // tbxCedula
            // 
            this.tbxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCedula.Location = new System.Drawing.Point(479, 27);
            this.tbxCedula.Name = "tbxCedula";
            this.tbxCedula.Size = new System.Drawing.Size(189, 22);
            this.tbxCedula.TabIndex = 2;
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono1.Location = new System.Drawing.Point(10, 263);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(75, 16);
            this.lblTelefono1.TabIndex = 29;
            this.lblTelefono1.Text = "Teléfono 1:";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono2.Location = new System.Drawing.Point(10, 303);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(75, 16);
            this.lblTelefono2.TabIndex = 28;
            this.lblTelefono2.Text = "Teléfono 2:";
            // 
            // lblTelefono3
            // 
            this.lblTelefono3.AutoSize = true;
            this.lblTelefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono3.Location = new System.Drawing.Point(10, 344);
            this.lblTelefono3.Name = "lblTelefono3";
            this.lblTelefono3.Size = new System.Drawing.Size(75, 16);
            this.lblTelefono3.TabIndex = 27;
            this.lblTelefono3.Text = "Teléfono 3:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(10, 76);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(139, 16);
            this.lblFechaNacimiento.TabIndex = 26;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(419, 30);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(54, 16);
            this.lblCedula.TabIndex = 25;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(10, 392);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 16);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.Location = new System.Drawing.Point(10, 163);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(76, 16);
            this.lblOcupacion.TabIndex = 22;
            this.lblOcupacion.Text = "Ocupación:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(76, 27);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(291, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblInstrumentos
            // 
            this.lblInstrumentos.AutoSize = true;
            this.lblInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInstrumentos.Location = new System.Drawing.Point(419, 76);
            this.lblInstrumentos.Name = "lblInstrumentos";
            this.lblInstrumentos.Size = new System.Drawing.Size(86, 16);
            this.lblInstrumentos.TabIndex = 64;
            this.lblInstrumentos.Text = "Instrumentos:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(170, 71);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(197, 22);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // clbInstrumentos
            // 
            this.clbInstrumentos.CheckOnClick = true;
            this.clbInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbInstrumentos.FormattingEnabled = true;
            this.clbInstrumentos.Location = new System.Drawing.Point(511, 71);
            this.clbInstrumentos.Name = "clbInstrumentos";
            this.clbInstrumentos.Size = new System.Drawing.Size(252, 140);
            this.clbInstrumentos.TabIndex = 12;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("btnCapturar.Image")));
            this.btnCapturar.Location = new System.Drawing.Point(662, 298);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(65, 65);
            this.btnCapturar.TabIndex = 14;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Location = new System.Drawing.Point(501, 234);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(145, 145);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 65;
            this.pbxFoto.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarImagen.Image")));
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(422, 298);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(65, 65);
            this.btnSeleccionarImagen.TabIndex = 13;
            this.btnSeleccionarImagen.Text = "Buscar";
            this.btnSeleccionarImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif|All files (*.*)|*.*";
            this.openFileDialog.Title = "Seleccione una foto";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(10, 119);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 68;
            this.lblEstado.Text = "Estado:";
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Checked = true;
            this.rbtnActivo.Location = new System.Drawing.Point(91, 118);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnActivo.TabIndex = 4;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Location = new System.Drawing.Point(163, 118);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtnInactivo.TabIndex = 5;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // V_AgregarModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(802, 520);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.clbInstrumentos);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblInstrumentos);
            this.Controls.Add(this.btnAgregarProf);
            this.Controls.Add(this.tbxTelefono3);
            this.Controls.Add(this.tbxTelefono2);
            this.Controls.Add(this.tbxTelefono1);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxOcupacion);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.tbxCedula);
            this.Controls.Add(this.lblTelefono1);
            this.Controls.Add(this.lblTelefono2);
            this.Controls.Add(this.lblTelefono3);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_AgregarModificarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.V_AgregarModificarProfesor_FormClosing);
            this.Load += new System.EventHandler(this.V_AgregarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProf;
        private System.Windows.Forms.TextBox tbxTelefono3;
        private System.Windows.Forms.TextBox tbxTelefono2;
        private System.Windows.Forms.TextBox tbxTelefono1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxOcupacion;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxCedula;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label lblTelefono3;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInstrumentos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckedListBox clbInstrumentos;
        private ErrorProvider errorProvider;
        private Button btnCapturar;
        private PictureBox pbxFoto;
        private Button btnSeleccionarImagen;
        private OpenFileDialog openFileDialog;
        private Label lblEstado;
        private RadioButton rbtnInactivo;
        private RadioButton rbtnActivo;
    }
}