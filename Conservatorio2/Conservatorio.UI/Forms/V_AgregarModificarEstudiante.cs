using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Drawing;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.DATOS.Enums;
using Conservatorio.DATOS.Helpers;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarEstudiante : Form
    {
        private readonly IEstudianteBL estudiantesBL;
        private readonly V_Estudiantes vEstudiantes;

        public Encargado Encargado { get; set; }
        public Image FotoEncargado { get; set; }

        private Estudiante estudiante;
        
        private Capture _capture;
        private Capture CameraCapture
        {
            get
            {
                if (_capture == null)
                {
                    _capture = new Capture();
                    _capture.SetCaptureProperty(CapProp.FrameHeight, 145);
                    _capture.SetCaptureProperty(CapProp.FrameWidth, 145);
                }
                return _capture;
            }
            set { _capture = value; }
        }

        private bool CaptureInProgress { get; set; }

        public V_AgregarModificarEstudiante(V_Estudiantes vEstudiantes, Estudiante estudiante = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            estudiantesBL = CapaLogica.EstudianteBl;
            this.vEstudiantes = vEstudiantes;
            this.estudiante = estudiante;
        }

        private void CargarTiposEstudiante()
        {
            cbxTipo.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<TipoEstudianteEnum>();
            cbxTipo.ValueMember = "Key";
            cbxTipo.DisplayMember = "Value";
        }

        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbxNombre,
                    MetodoValidacion = (out string errorMsg) => !tbxNombre.ValidarRequerido(out errorMsg)
                },
                new Validador
                {
                    Control = tbxCedula,
                    MetodoValidacion = (out string errorMsg) => !tbxCedula.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxEmail,
                    MetodoValidacion = (out string errorMsg) => !tbxEmail.ValidarEmail(out errorMsg)
                },
                new Validador
                {
                    Control = tbxTel1,
                    MetodoValidacion = (out string errorMsg) => !tbxTel1.ValidarRequerido(out errorMsg) || !tbxTel1.ValidarEntero(out errorMsg) || !tbxTel1.ValidarLargo(8, out errorMsg)
                },
                new Validador
                {
                    Control = dtpFechaNacimiento,
                    MetodoValidacion = (out string errorMsg) => !dtpFechaNacimiento.ValidarRequerido(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            var queryFrame = CameraCapture.QueryFrame();
            if (queryFrame == null)
            {
                this.MostrarMensaje("No hay cámara disponible.");
                btnCapturar.PerformClick();
                return;
            }

            var image = queryFrame.Bitmap;
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbxFoto.Image = image;
        }

        #region Action Methods

        private void V_AgregarModificarEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTiposEstudiante();

                Text = estudiante == null ? "Agregar Estudiante" : "Modificar Estudiante";

                if (estudiante == null)
                {
                    return;
                }

                Encargado = estudiante.Encargado;
                tbxNombre.Text = estudiante.Nombre;
                tbxCedula.Text = estudiante.Cedula.ToString();
                tbxDireccion.Text = estudiante.Direccion;
                tbxOcupacion.Text = estudiante.Ocupacion;
                dtpFechaNacimiento.Value = estudiante.FechaNacimiento ?? DateTime.Now;
                tbxEmail.Text = estudiante.Email;
                tbxGradoAcademico.Text = estudiante.GradoAcademico;
                tbxTel1.Text = estudiante.Telefono1.ToString();
                tbxTel2.Text = estudiante.Telefono2.ToString();
                tbxTel3.Text = estudiante.Telefono3.ToString();
                cbxTipo.SelectedValue = estudiante.Tipo;
                rbtnActivo.Checked = estudiante.Estado;
                rbtnInactivo.Checked = !estudiante.Estado;

                if (!string.IsNullOrEmpty(estudiante.Imagen))
                {
                    pbxFoto.Image = SharedFolderHelper.GetImage(estudiante.Imagen);
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    pbxFoto.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaptureInProgress)
                {
                    Application.Idle -= ProcessFrame;
                    CameraCapture.Dispose();
                    CameraCapture = null;
                }
                else
                {
                    Application.Idle += ProcessFrame;
                }

                CaptureInProgress = !CaptureInProgress;
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                if (estudiante == null)
                {
                    estudiante = new Estudiante();
                }

                estudiante.Nombre = tbxNombre.Text;
                estudiante.Cedula = tbxCedula.Text == "" ? (long?)null : long.Parse(tbxCedula.Text);
                estudiante.Direccion = tbxDireccion.Text;
                estudiante.Email = tbxEmail.Text;
                estudiante.FechaNacimiento = dtpFechaNacimiento.Value;
                estudiante.GradoAcademico = tbxGradoAcademico.Text;
                estudiante.Ocupacion = tbxOcupacion.Text;
                estudiante.Telefono1 = int.Parse(tbxTel1.Text);
                estudiante.Telefono2 = tbxTel2.Text == "" ? (int?)null : int.Parse(tbxTel2.Text);
                estudiante.Telefono3 = tbxTel3.Text == "" ? (int?)null : int.Parse(tbxTel3.Text);
                estudiante.Tipo = cbxTipo.SelectedValue.ToString();
                estudiante.Estado = rbtnActivo.Checked;
                estudiante.Encargado = Encargado;

                //Se crea un nuevo nombre para las imagenes solo si no existen
                var foto = pbxFoto.Image;
                if (foto != null && string.IsNullOrEmpty(estudiante.Imagen))
                {
                    estudiante.Imagen = Guid.NewGuid() + ".png";
                }
                if (Encargado != null && FotoEncargado != null && string.IsNullOrEmpty(Encargado.Imagen))
                {
                    Encargado.Imagen = Guid.NewGuid() + ".png";
                }

                if (estudiante.IdPersona == 0)
                {
                    estudiantesBL.CrearEstudiante(estudiante);
                }
                else
                {
                    estudiantesBL.ModificarEstudiante(estudiante);
                }

                // Guardar las imagenes
                if (foto != null)
                {
                    SharedFolderHelper.Save(foto, estudiante.Imagen);
                }
                if (Encargado != null && FotoEncargado != null)
                {
                    SharedFolderHelper.Save(FotoEncargado, Encargado.Imagen);
                }

                Close();
                vEstudiantes.RefrescarEstudiantes();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnEncargado_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new V_AgregarModificarEncargado(this, Encargado);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void V_AgregarModificarEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (CaptureInProgress)
                {
                    Application.Idle -= ProcessFrame;
                    CameraCapture.Dispose();
                    CameraCapture = null;
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

    }
}
