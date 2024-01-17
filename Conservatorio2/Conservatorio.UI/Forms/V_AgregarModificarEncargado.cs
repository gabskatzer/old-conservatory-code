using Conservatorio.DATOS;
using Conservatorio.UI.FormValidation;
using System;
using System.Drawing;
using System.Windows.Forms;
using Conservatorio.UI.Helpers;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarEncargado : Form
    {
        private readonly V_AgregarModificarEstudiante vAgregarModificarEstudiante;

        private Encargado Encargado { get; set; }

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

        public V_AgregarModificarEncargado(V_AgregarModificarEstudiante vAgregarModificarEstudiante, Encargado encargado = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            this.vAgregarModificarEstudiante = vAgregarModificarEstudiante;
            Encargado = encargado;
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
                    Control = tbxParentesco,
                    MetodoValidacion = (out string errorMsg) => !tbxParentesco.ValidarRequerido(out errorMsg)
                },
                new Validador
                {
                    Control = tbxEmail,
                    MetodoValidacion = (out string errorMsg) => !tbxEmail.ValidarEmail(out errorMsg)
                },
                new Validador
                {
                    Control = tbxTelefono1,
                    MetodoValidacion = (out string errorMsg) => !tbxTelefono1.ValidarRequerido(out errorMsg) || !tbxTelefono1.ValidarEntero(out errorMsg) || !tbxTelefono1.ValidarLargo(8, out errorMsg)
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

        private void V_AgregarModificarEncargado_Load(object sender, EventArgs e)
        {
            try
            {
                Text = Encargado == null ? "Agregar Encargado" : "Modificar Encargado";

                if (Encargado == null)
                {
                    return;
                }

                tbxNombre.Text = Encargado.Nombre;
                tbxParentesco.Text = Encargado.Parentesco;
                tbxEmail.Text = Encargado.Email;
                tbxTelefono1.Text = Encargado.Telefono1.ToString();
                tbxTelefono2.Text = Encargado.Telefono2.ToString();
                tbxTelefono3.Text = Encargado.Telefono3.ToString();

                if (!string.IsNullOrEmpty(Encargado.Imagen))
                {
                    pbxFoto.Image = SharedFolderHelper.GetImage(Encargado.Imagen);
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

                if (Encargado == null)
                {
                    Encargado = new Encargado
                    {
                        Estado = true
                    };
                }

                Encargado.Nombre = tbxNombre.Text;
                Encargado.Parentesco = tbxParentesco.Text;
                Encargado.Email = tbxEmail.Text;
                Encargado.Telefono1 = int.Parse(tbxTelefono1.Text);
                Encargado.Telefono2 = tbxTelefono2.Text == "" ? (int?)null : int.Parse(tbxTelefono2.Text);
                Encargado.Telefono3 = tbxTelefono3.Text == "" ? (int?)null : int.Parse(tbxTelefono3.Text);

                vAgregarModificarEstudiante.Encargado = Encargado;
                vAgregarModificarEstudiante.FotoEncargado = pbxFoto.Image;

                Close();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void V_AgregarModificarEncargado_FormClosing(object sender, FormClosingEventArgs e)
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
