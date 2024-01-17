using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarProfesor : Form
    {
        private readonly IProfesorBL profesorBL;
        private readonly IInstrumentoBL instrumentoBL;
        private readonly V_Profesores vProfesor;
        private Profesor profesor;

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

        public V_AgregarModificarProfesor(V_Profesores vProfesor, Profesor profesor = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            this.vProfesor = vProfesor;
            this.profesor = profesor;
            profesorBL = CapaLogica.ProfesorBl;
            instrumentoBL = CapaLogica.InstrumentoBl;
        }

        private void CargarInstrumentos()
        {
            clbInstrumentos.DataSource = instrumentoBL.ObtenerInstrumentos();
            clbInstrumentos.DisplayMember = "NombreInstrumento";
            clbInstrumentos.ValueMember = "IdInstrumento";
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
                    MetodoValidacion = (out string errorMsg) => !tbxCedula.ValidarRequerido(out errorMsg) || !tbxCedula.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxOcupacion,
                    MetodoValidacion = (out string errorMsg) => !tbxOcupacion.ValidarRequerido(out errorMsg)
                },
                new Validador
                {
                    Control = tbxEmail,
                    MetodoValidacion = (out string errorMsg) => !tbxEmail.ValidarRequerido(out errorMsg) || !tbxEmail.ValidarEmail(out errorMsg)
                },
                new Validador
                {
                    Control = tbxTelefono1,
                    MetodoValidacion = (out string errorMsg) => !tbxTelefono1.ValidarRequerido(out errorMsg) || !tbxTelefono1.ValidarEntero(out errorMsg) || !tbxTelefono1.ValidarLargo(8, out errorMsg)
                },
                new Validador
                {
                    Control = tbxTelefono2,
                    MetodoValidacion = (out string errorMsg) => !tbxTelefono2.ValidarEntero(out errorMsg) || !tbxTelefono2.ValidarLargo(8, out errorMsg)
                },
                new Validador
                {
                    Control = tbxTelefono3,
                    MetodoValidacion = (out string errorMsg) => !tbxTelefono3.ValidarEntero(out errorMsg) || !tbxTelefono3.ValidarLargo(8, out errorMsg)
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

        private void V_AgregarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                CargarInstrumentos();

                Text = profesor == null ? "Agregar Profesor" : "Modificar Profesor";

                if (profesor == null)
                {
                    return;
                }

                tbxNombre.Text = profesor.Nombre;
                tbxCedula.Text = profesor.Cedula.ToString();
                tbxDireccion.Text = profesor.Direccion;
                tbxOcupacion.Text = profesor.Ocupacion;
                dtpFechaNacimiento.Value = profesor.FechaNacimiento ?? DateTime.Now;
                tbxEmail.Text = profesor.Email;
                tbxTelefono1.Text = profesor.Telefono1.ToString();
                tbxTelefono2.Text = profesor.Telefono2.ToString();
                tbxTelefono3.Text = profesor.Telefono3.ToString();
                rbtnActivo.Checked = profesor.Estado;
                rbtnInactivo.Checked = !profesor.Estado;

                var idsInstrumentos = profesor.Instrumentos.Select(x => x.IdInstrumento).ToList();
                for (var i = 0; i < clbInstrumentos.Items.Count; i++)
                {
                    var instrumento = (Instrumento)clbInstrumentos.Items[i];
                    if (idsInstrumentos.Contains(instrumento.IdInstrumento))
                    {
                        clbInstrumentos.SetItemChecked(i, true);
                    }
                }

                if (!string.IsNullOrEmpty(profesor.Imagen))
                {
                    pbxFoto.Image = SharedFolderHelper.GetImage(profesor.Imagen);
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnAgregarProf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                if (profesor == null)
                {
                    profesor = new Profesor();
                }

                profesor.Cedula = long.Parse(tbxCedula.Text);
                profesor.Direccion = tbxDireccion.Text;
                profesor.Email = tbxEmail.Text;
                profesor.FechaNacimiento = dtpFechaNacimiento.Value;
                profesor.Nombre = tbxNombre.Text;
                profesor.Ocupacion = tbxOcupacion.Text;
                profesor.Telefono1 = int.Parse(tbxTelefono1.Text);
                profesor.Telefono2 = string.IsNullOrEmpty(tbxTelefono2.Text) ? (int?)null : int.Parse(tbxTelefono2.Text);
                profesor.Telefono3 = string.IsNullOrEmpty(tbxTelefono3.Text) ? (int?)null : int.Parse(tbxTelefono3.Text);
                profesor.Instrumentos = clbInstrumentos.CheckedItems.Cast<Instrumento>().ToList();
                profesor.Estado = rbtnActivo.Checked;

                //Se crea un nuevo nombre para la imagen solo si no existe
                var foto = pbxFoto.Image;
                if (foto != null && string.IsNullOrEmpty(profesor.Imagen))
                {
                    profesor.Imagen = Guid.NewGuid() + ".png";
                }

                if (profesor.IdPersona == 0)
                {
                    profesorBL.CrearProfesor(profesor);
                }
                else
                {
                    profesorBL.ModificarProfesor(profesor);
                }

                // Guardar la imagen
                if (foto != null)
                {
                    SharedFolderHelper.Save(foto, profesor.Imagen);
                }

                Close();
                vProfesor.RefrescarProfesores();
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

        private void V_AgregarModificarProfesor_FormClosing(object sender, FormClosingEventArgs e)
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
