using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.DATOS.Helpers;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarClase : Form
    {
        private readonly IClaseBL _claseBL;
        private readonly IInstrumentoBL _instrumentoBL;
        private readonly ICursoBL _cursoBL;
        private readonly IProfesorBL _profesorBL;
        private readonly V_Clases _vClases;

        private List<Clase> listaClases;
        private Clase clase;

        public V_AgregarModificarClase(V_Clases vClases, Clase clase)
        {
            InitializeComponent();
            ConfigurarValidacion();

            //Formatear Horario
            dgvHorario.Columns.Cast<DataGridViewColumn>().ToList().ForEach(x => x.SortMode = DataGridViewColumnSortMode.NotSortable);

            _claseBL = CapaLogica.ClaseBl;
            _instrumentoBL = CapaLogica.InstrumentoBl;
            _cursoBL = CapaLogica.CursoBl;
            _profesorBL = CapaLogica.ProfesorBl;
            _vClases = vClases;
            this.clase = clase;
        }
		
        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbxAula,
                    MetodoValidacion = (out string errorMsg) => !tbxAula.ValidarRequerido(out errorMsg) || !tbxAula.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = tbxAno,
                    MetodoValidacion = (out string errorMsg) => !tbxAno.ValidarRequerido(out errorMsg) || !tbxAno.ValidarEntero(out errorMsg)
                },
                new Validador
                {
                    Control = dgvHorario,
                    MetodoValidacion = (out string errorMsg) => !dgvHorario.ValidarRequerido(out errorMsg) || !dgvHorario.ValidarRango(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        private void CargarInstrumentos()
        {
            cbxInstrumento.DataSource = _instrumentoBL.ObtenerInstrumentos();
            cbxInstrumento.ValueMember = "IdInstrumento";
            cbxInstrumento.DisplayMember = "NombreInstrumento";
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

        private void CargarCursos()
        {
            var instrumentoSeleccionado = ObtenerInstrumentoSeleccionado();
            if (instrumentoSeleccionado == null)
            {
                return;
            }

            cbxCursos.DataSource = _cursoBL.ObtenerCursosPorInstrumento(instrumentoSeleccionado.IdInstrumento);
            cbxCursos.ValueMember = "IdCurso";
            cbxCursos.DisplayMember = "NombreCurso";
        }

        private void CargarProfesores()
        {
            var instrumentoSeleccionado = ObtenerInstrumentoSeleccionado();
            if (instrumentoSeleccionado == null)
            {
                return;
            }

            cbxProfesores.DataSource = _profesorBL.ObtenerProfesoresPorInstrumento(instrumentoSeleccionado.IdInstrumento);
            cbxProfesores.ValueMember = "IdPersona";
            cbxProfesores.DisplayMember = "Nombre";
        }

        private Instrumento ObtenerInstrumentoSeleccionado()
        {
            return cbxInstrumento.SelectedItem as Instrumento;
        }

        private Profesor ObtenerProfesorSeleccionado()
        {
            return cbxProfesores.SelectedItem as Profesor;
        }

        private DiaHorasModel ObtenerDiaHorasSeleccionado()
        {
            var celdasSeleccionadas = dgvHorario.SelectedCells.Cast<DataGridViewCell>().ToList().OrderBy(x => x.RowIndex);
            var diaIdx = celdasSeleccionadas.First().ColumnIndex - 1;

            var hora = DateTime.Now;
            var horaInicioIdx = celdasSeleccionadas.First().RowIndex + 8;
            var horaInicio = new DateTime(hora.Year, hora.Month, hora.Day, horaInicioIdx, 0, 0);

            var horaFinalIdx = celdasSeleccionadas.Last().RowIndex + 9;
            var horaFinal = new DateTime(hora.Year, hora.Month, hora.Day, horaFinalIdx, 0, 0);

            return new DiaHorasModel
            {
                Dia = (DiasEnum)diaIdx,
                HoraInicio = horaInicio,
                HoraFinal = horaFinal
            };
        }

        private void RefrescarClases()
        {
            var ano = tbxAno.Text;
            var periodo = cbxPeriodo.SelectedValue as int?;
            var profesor = ObtenerProfesorSeleccionado();
            var aula = tbxAula.Text;
            if (string.IsNullOrWhiteSpace(ano) || !periodo.HasValue || profesor == null || string.IsNullOrWhiteSpace(aula))
            {
                return;
            }

            listaClases = _claseBL.ObtenerClases(periodo.Value, int.Parse(ano), profesor, int.Parse(aula));
            dgvHorario.DataSource = listaClases.ToDataTable();

            dgvHorario.Columns.Cast<DataGridViewColumn>().ToList().ForEach(x => x.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        #region Action Methods

        private void V_AgregarModificarClase_Load(object sender, EventArgs e)
        {
            try
            {
                CargarInstrumentos();
            	CargarPeriodos();

                if (clase == null)
                {
                    Text = "Agregar Clase";
                    tbxAula.Text = "1";
                    tbxAno.Text = DateTime.Now.Year.ToString();
                }
                else
                {
                    Text = "Modificar Clase";
                    cbxInstrumento.SelectedValue = clase.Curso.Instrumento.IdInstrumento;
                    cbxCursos.SelectedValue = clase.Curso.IdCurso;
                    cbxProfesores.SelectedValue = clase.Profesor.IdPersona;
                    tbxAula.Text = clase.Aula.ToString();
                    cbxPeriodo.SelectedItem = clase.Periodo;
                    tbxAno.Text = clase.Ano.ToString();
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void cbxInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarCursos();
                CargarProfesores();
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
                RefrescarClases();
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
                RefrescarClases();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void cbxProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarClases();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void tbxAula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefrescarClases();
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

                if (clase == null)
                {
                    clase = new Clase();
                }

                clase.Curso = cbxCursos.SelectedItem as Curso;
                clase.Profesor = cbxProfesores.SelectedItem as Profesor;
                clase.Aula = int.Parse(tbxAula.Text);
                clase.Periodo = (int) cbxPeriodo.SelectedValue;
                clase.Ano = int.Parse(tbxAno.Text);

                var diaHoras = ObtenerDiaHorasSeleccionado();
                clase.Dia = diaHoras.Dia.ToString();
                clase.HoraInicio = diaHoras.HoraInicio.ToString(DateTimeHelper.Constants.HourMinutesMeridianFormat);
                clase.HoraFinal = diaHoras.HoraFinal.ToString(DateTimeHelper.Constants.HourMinutesMeridianFormat);

                if (clase.IdClase == 0)
                {
                    _claseBL.CrearClase(clase);
                }
                else
                {
                    _claseBL.ModificarClase(clase);
                }

                Close();
                _vClases.RefrescarClases();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

    }
}
