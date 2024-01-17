using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.FormValidation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.DATOS.Helpers;
using Conservatorio.UI.Helpers;

namespace Conservatorio.UI.Forms
{
    public partial class V_Matricula : Form
    {
        private readonly IEstudianteBL estudianteBL;
        private readonly IClaseBL claseBL;
        private readonly IInstrumentoBL instrumentoBL;
        private readonly IRegistroNotaBL registroNotaBL;
        private readonly IPagoMatriculaBL pagoMatriculaBL;

        private List<Estudiante> listaEstudiantes;
        private List<Clase> listaClases;
        private List<Clase> listaClasesDisponibles;

        public V_Matricula()
        {
            InitializeComponent();
            ConfigurarValidacion();

            estudianteBL = CapaLogica.EstudianteBl;
            instrumentoBL = CapaLogica.InstrumentoBl;
            claseBL = CapaLogica.ClaseBl;
            registroNotaBL = CapaLogica.RegistroNotaBl;
            pagoMatriculaBL = CapaLogica.PagoMatriculaBl;
        }

        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbxAno,
                    MetodoValidacion = (out string errorMsg) => !tbxAno.ValidarRequerido(out errorMsg) || !tbxAno.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxMonto,
                    MetodoValidacion = (out string errorMsg) => !tbxMonto.ValidarRequerido(out errorMsg) || !tbxMonto.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxReferencia,
                    MetodoValidacion = (out string errorMsg) => !tbxReferencia.ValidarRequerido(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        private void RefrescarEstudiantes()
        {
            var keyword = tbxBuscarEstudiante.Text;
            listaEstudiantes = estudianteBL.ObtenerEstudiantes(keyword, false);
            dgvEstudiantes.DataSource = listaEstudiantes.Select(x => new EstudianteModel
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
                Telefono1Encargado = x.Encargado == null ? (int?) null : x.Encargado.Telefono1,
                Telefono2Encargado = x.Encargado == null ? null : x.Encargado.Telefono2,
                Telefono3Encargado = x.Encargado == null ? null : x.Encargado.Telefono3,
                EmailEncargado = x.Encargado == null ? string.Empty : x.Encargado.Email
            }).ToList();
        }

        private void RefrescarClasesDelPeriodo()
        {
            if (string.IsNullOrEmpty(tbxAno.Text))
            {
                return;
            }

            var ano = int.Parse(tbxAno.Text);
            var periodo = (int)cbxPeriodo.SelectedItem;

            listaClases = claseBL.ObtenerClasesConCupo(periodo, ano);
        }

        private void CargarPeriodos()
        {
            var list = new List<int>();
            var cantidadPeriodos = int.Parse(ConfigurationManager.AppSettings["cantidadPeriodos"]);
            for (var i = 1; i <= cantidadPeriodos; i++)
            {
                list.Add(i);
            }
            cbxPeriodo.DataSource = list;
        }

        private void CargarTipoPagos()
        {
            cbxTipoPago.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<TipoPagoEnum>();
            cbxTipoPago.ValueMember = "Key";
            cbxTipoPago.DisplayMember = "Value";
        }

        private void CargarInstrumentos()
        {
            clbInstrumentos.DataSource = instrumentoBL.ObtenerInstrumentos();
            clbInstrumentos.DisplayMember = "NombreInstrumento";
            clbInstrumentos.ValueMember = "IdInstrumento";
        }

        private void SeleccionarInstrumentosPorEstudiante(Estudiante estudiante)
        {
            for (var i = 0; i < clbInstrumentos.Items.Count; i++)
            {
                var idsInstrumentosEstudiante = estudiante.Instrumentos.Select(x => x.IdInstrumento);
                var instrumento = clbInstrumentos.Items[i] as Instrumento;
                var check = idsInstrumentosEstudiante.Contains(instrumento.IdInstrumento);
                clbInstrumentos.SetItemChecked(i, check);
            }
        }

        private void PreseleccionarPeriodo()
        {
            var datos = pagoMatriculaBL.ObtenerPeriodoActual();
            var periodo = datos.Item1;
            var ano = datos.Item2;

            cbxPeriodo.SelectedItem = periodo;
            tbxAno.Text = ano.ToString();
        }

        private Estudiante ObtenerEstudianteSeleccionado()
        {
            if (dgvEstudiantes.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvEstudiantes.SelectedRows[0].Index;
            return listaEstudiantes[selectedIndex];
        }

        private List<Instrumento> ObtenerInstrumentosSeleccionados()
        {
            return clbInstrumentos.CheckedItems.Cast<Instrumento>().ToList();
        }

        private List<Clase> ObtenerClasesSeleccionadas()
        {
            var resultado = new List<Clase>();
            var clasesSeleccionadas = dgvClases.SelectedRows;
            if (clasesSeleccionadas.Count == 0)
            {
                return resultado;
            }

            foreach (var clasesSeleccionada in clasesSeleccionadas.Cast<DataGridViewRow>())
            {
                var idx = clasesSeleccionada.Index;
                resultado.Add(listaClasesDisponibles[idx]);
            }

            return resultado;
        }

        #region Action Methods

        private void V_Matricula_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPeriodos();
                CargarTipoPagos();
                CargarInstrumentos();

                PreseleccionarPeriodo();
                RefrescarEstudiantes();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void tbxBuscarEst_Matric_TextChanged(object sender, EventArgs e)
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

        private void cbxPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarClasesDelPeriodo();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void tbxAno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarClasesDelPeriodo();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void dgvEst_Matric_DoubleClick(object sender, EventArgs e)
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

                SeleccionarInstrumentosPorEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void clbInstrumentos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    var estudiante = ObtenerEstudianteSeleccionado();
                    if (estudiante == null)
                    {
                        return;
                    }

                    var instrumentosSeleccionados = ObtenerInstrumentosSeleccionados();
                    var cursosAprobados = registroNotaBL.ObtenerCursosAprobados(estudiante);
                    listaClasesDisponibles = claseBL.ObtenerClasesDisponibles(listaClases, instrumentosSeleccionados,cursosAprobados).ToList();
                    dgvClases.DataSource = listaClasesDisponibles.Select(x => new ClaseModel
                    {
                        Profesor = x.Profesor.Nombre,
                        Curso = x.Curso.NombreCurso,
                        Dia = x.Dia,
                        HoraInicio = x.HoraInicio,
                        HoraFinal = x.HoraFinal,
                        Aula = x.Aula,
                        Periodo = string.Format("{0}-{1}", x.Periodo, x.Ano)
                    }).ToList();
                }));
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
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

                var clases = ObtenerClasesSeleccionadas();

                var registrosNota = new List<RegistroNota>();
                foreach (var clase in clases)
                {
                    if (!estudiante.Instrumentos.Select(x => x.IdInstrumento).Contains(clase.Curso.Instrumento.IdInstrumento))
                    {
                        estudiante.Instrumentos.Add(clase.Curso.Instrumento);
                    }

                    var registroNota = new RegistroNota
                    {
                        Estudiante = estudiante,
                        Clase = clase,
                        Nota = 0
                    };
                    registrosNota.Add(registroNota);
                }

                var pagoMatricula = new PagoMatricula
                {
                    Estudiante = estudiante,
                    Periodo = ((int)cbxPeriodo.SelectedItem).ToString(),
                    Comentario = tbxComentario.Text,
                    TipoPago = cbxTipoPago.SelectedValue.ToString(),
                    Año = int.Parse(tbxAno.Text),
                    FechaPago = DateTime.Now,
                    Monto = float.Parse(tbxMonto.Text),
                    Referencia = tbxReferencia.Text
                };

                //salvar en EstudianteInstrumento
                estudianteBL.ModificarEstudiante(estudiante);

                //salvar en RegistroNota
                registrosNota.ForEach(x => registroNotaBL.CrearRegistroNota(x));

                //salvar en PagoMatricula
                pagoMatriculaBL.CrearPagoMatricula(pagoMatricula);

                this.MostrarMensaje("Estudiante matriculado con éxito!");
                Close();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion
        
    }
}
