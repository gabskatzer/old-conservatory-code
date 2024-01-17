using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.DATOS.Helpers;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_Mensualidad : Form
    {
        private readonly IEstudianteBL estudianteBL;
        private readonly IPagoMensualidadBL pagoMensualidadBL;

        private List<Estudiante> listaEstudiantes;
        private PagoMensualidad mensualidad;
        public V_Mensualidad()
        {
            InitializeComponent();
            ConfigurarValidacion();

            estudianteBL = CapaLogica.EstudianteBl;
            pagoMensualidadBL = CapaLogica.PagoMensualidadBl;

        }

        private void V_Mensualidad_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarEstudiantes();
                CargarTipoPagos();
                CargarMeses();

                tbxAno.Text = DateTime.Now.Year.ToString();

            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                
                new Validador
                {
                    Control = tbxMontoMens,
                    MetodoValidacion = (out string errorMsg) => !tbxMontoMens.ValidarRequerido(out errorMsg) || !tbxMontoMens.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxReferencia,
                    MetodoValidacion = (out string errorMsg) => !tbxReferencia.ValidarRequerido(out errorMsg)
                },
                new Validador
                {
                    Control = tbxMulta,
                    MetodoValidacion = (out string errorMsg) => !tbxMulta.ValidarEntero(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        private void RefrescarEstudiantes()
        {
            
            var keyword = tbxBuscarEst_Mensualidad.Text;
            listaEstudiantes = estudianteBL.ObtenerEstudiantes(keyword, false);
            dgvEst_Mensualidad.DataSource = listaEstudiantes.Select(x => new EstudianteModel
            {
                IdEstudiante = x.IdPersona,
                Nombre = x.Nombre,
                Cedula = x.Cedula,
                Direccion = x.Direccion,
                Ocupacion = x.Ocupacion,
                GradoAcademico = x.GradoAcademico,
                Email = x.Email,
                Estado = x.Estado ? "Activo" : "Inactivo",
                FechaNacimiento = x.FechaNacimiento.Value.ToShortDateString(),
                Telefono1 = x.Telefono1,
                Telefono2 = x.Telefono2,
                Telefono3 = x.Telefono3,
                NombreEncargado = x.Encargado == null ? string.Empty : x.Encargado.Nombre,
                Parentesco = x.Encargado == null ? string.Empty : x.Encargado.Parentesco,
                Telefono1Encargado = x.Encargado == null ? (int?)null : x.Encargado.Telefono1,
                Telefono2Encargado = x.Encargado == null ? null : x.Encargado.Telefono2,
                Telefono3Encargado = x.Encargado == null ? null : x.Encargado.Telefono3,
                EmailEncargado = x.Encargado == null ? string.Empty : x.Encargado.Email
            }).ToList();
        }

        private Estudiante ObtenerEstudianteSeleccionado()
        {
            if (dgvEst_Mensualidad.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvEst_Mensualidad.SelectedRows[0].Index;
            return listaEstudiantes[selectedIndex];
        }

        private void tbxBuscarEst_Mensualidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarEstudiantes();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void dgvEst_Mensualidad_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var estudiante = ObtenerEstudianteSeleccionado();
                if (estudiante == null)
                {
                    return;
                }

                lblNombreEstudiante.Text = estudiante.Nombre;
                lblTipoEstudiante.Text = estudiante.Tipo;
                if (!string.IsNullOrEmpty(estudiante.Imagen))
                {
                    var bytes = File.ReadAllBytes(ConfigurationManager.AppSettings["imagesFolder"] + estudiante.Imagen);
                    var ms = new MemoryStream(bytes);
                    pbxEstudiante.Image = Image.FromStream(ms);
                }
                else
                {
                    pbxEstudiante.Image = null;
                }

            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void CargarTipoPagos()
        {
            cbxTipoPago.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<TipoPagoEnum>();
            cbxTipoPago.ValueMember = "Key";
            cbxTipoPago.DisplayMember = "Value";
        }

        private void CargarMeses()
        {
            cbxMes.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<MesesEnum>();
            cbxMes.ValueMember = "Key";
            cbxMes.DisplayMember = "Value";
        }

        private void btnSalvarMensualidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                var estudiante = ObtenerEstudianteSeleccionado();
                if (estudiante == null)
                {
                    return;
                }
                var pagoMensualidad = new PagoMensualidad
                {
                    Estudiante = estudiante,
                    Comentario = tbxComentario.Text,
                    TipoPago = cbxTipoPago.SelectedValue.ToString(),
                    FechaPago = DateTime.Now,
                    Monto = float.Parse(tbxMontoMens.Text),
                    Referencia = tbxReferencia.Text,
                    Multa = float.Parse(tbxMulta.Text),
                    Mes = cbxMes.SelectedValue.ToString(),
                    Ano = int.Parse(tbxAno.Text)                  
                };

                pagoMensualidadBL.CrearPagoMensualidad(pagoMensualidad);

                Close();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void tbxMulta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotal();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
            
        }

        private void tbxMontoMens_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotal();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void CalcularTotal()
        {
            if (!ValidateChildren())
            {
                return;
            }

            var resultado = Convert.ToDouble(tbxMontoMens.Text) + Convert.ToDouble(tbxMulta.Text);
            lblTotalCol.Text = resultado.ToString();
        }
    }
}
