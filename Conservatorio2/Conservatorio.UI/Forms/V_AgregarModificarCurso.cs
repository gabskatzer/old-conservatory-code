using System;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarCurso : Form
    {
        private readonly ICursoBL cursoBL;
        private readonly V_Cursos vCursos;
        private readonly Instrumento instrumento;
        private Curso curso;

        public V_AgregarModificarCurso(V_Cursos vCursos, Instrumento instrumento, Curso curso = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            this.vCursos = vCursos;
            this.curso = curso;
            this.instrumento = instrumento;
            cursoBL = CapaLogica.CursoBl;
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
                    Control = tbxNivel,
                    MetodoValidacion = (out string errorMsg) => !tbxNivel.ValidarRequerido(out errorMsg) || !tbxNivel.ValidarEntero(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        private void CargarRequisitos()
        {
            var nullRequisito = new Curso {IdCurso = 0, NombreCurso = "(ninguno)"};
            var listaRequisitos = cursoBL.ObtenerCursosPorInstrumento(instrumento.IdInstrumento);
            if (curso != null)
            {
                listaRequisitos.RemoveAll(x => x.IdCurso == curso.IdCurso);
            }
            listaRequisitos.Insert(0, nullRequisito);

            cbxRequisito.DataSource = listaRequisitos;
            cbxRequisito.ValueMember = "IdCurso";
            cbxRequisito.DisplayMember = "NombreCurso";
        }

        private Curso ObtenerRequisitoSeleccionado()
        {
            Curso requisito = null;
            if (cbxRequisito.SelectedIndex > 0)
            {
                var requisitoSeleccionado = cbxRequisito.SelectedItem as Curso;
                if (requisitoSeleccionado != null && requisitoSeleccionado.IdCurso != 0)
                {
                    requisito = requisitoSeleccionado;
                }
            }

            return requisito;
        }

        #region Action Methods

        private void V_AgregarModificarCurso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarRequisitos();
                tbxInstrumento.Text = instrumento.NombreInstrumento;

                if (curso == null)
                {
                    Text = "Agregar Curso";
                }
                else
                {
                    Text = "Modificar Curso";
                    tbxNombre.Text = curso.NombreCurso;
                    tbxNivel.Text = curso.Nivel.ToString();
                    if (curso.CursoRequisito != null)
                    {
                        cbxRequisito.SelectedValue = curso.CursoRequisito.IdCurso;
                    }
                }
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void cbxRequisito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var requisitoSeleccionado = ObtenerRequisitoSeleccionado();

                var nuevoNivel = 1;
                if (requisitoSeleccionado != null)
                {
                    nuevoNivel = requisitoSeleccionado.Nivel + 1;
                }

                tbxNivel.Text = nuevoNivel.ToString();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                if (curso == null)
                {
                    curso = new Curso();
                }

                curso.Instrumento = instrumento;
                curso.NombreCurso = tbxNombre.Text;
                curso.Nivel = int.Parse(tbxNivel.Text);
                curso.CursoRequisito = ObtenerRequisitoSeleccionado();

                if (curso.IdCurso == 0)
                {
                    cursoBL.CrearCurso(curso);
                }
                else
                {
                    cursoBL.ModificarCurso(curso);
                }

                Close();
                vCursos.RefrescarCursos();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

    }
}
