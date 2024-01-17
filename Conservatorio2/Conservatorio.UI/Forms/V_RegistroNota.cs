using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_RegistroNota : Form
    {
        private readonly IClaseBL claseBL;
        private readonly IRegistroNotaBL registroNotaBL;

        private List<Clase> listaClases;
        private List<RegistroNota> listaRegistroNotas;

        public V_RegistroNota()
        {
            InitializeComponent();
            ConfigurarValidacion();
            claseBL = CapaLogica.ClaseBl;
            registroNotaBL = CapaLogica.RegistroNotaBl;
        }

        private void V_RegistroNota_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPeriodos();
                RefrescarClases();
                

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
                    Control = tbxAno,
                    MetodoValidacion = (out string errorMsg) => !tbxAno.ValidarRequerido(out errorMsg) || !tbxAno.ValidarEntero(out errorMsg) || !tbxAno.ValidarLargo(4, out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
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

        private void RefrescarClases()
        {
            if (!ValidateChildren())
            {
                return;
            }

            var periodoSeleccionado = (int)cbxPeriodo.SelectedItem;
            var ano = int.Parse(tbxAno.Text);

            var keyword = tbxBuscarClases.Text;
            listaClases = claseBL.ObtenerClases(periodoSeleccionado, ano, keyword);
            dgvClases.DataSource = listaClases.Select(x => new ClaseModel
            {
                Aula = x.Aula,
                Curso = x.Curso.NombreCurso,
                Dia = x.Dia,
                HoraFinal = x.HoraFinal,
                HoraInicio = x.HoraInicio,
                Periodo = x.Periodo + " - " + x.Ano,
                Profesor = x.Profesor.Nombre

            }).ToList();
        }

        private void RefrescarEstudiantes()
        {
            var clase = ObtenerClaseSeleccionada();

            if (clase == null)
            {
                return;
            }

            var keyword = tbxBuscarEstudiantes.Text;
            listaRegistroNotas = registroNotaBL.ObtenerRegistroNotas(clase, keyword);
            dgvEstudiantes.DataSource = listaRegistroNotas.Select(x => x.Estudiante).Select(x => new EstudianteModel
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

        private RegistroNota ObtenerRegistroNotaSeleccionada()
        {
            if (dgvEstudiantes.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvEstudiantes.SelectedRows[0].Index;
            return listaRegistroNotas[selectedIndex];
        }

        private void tbxBuscarClases_TextChanged(object sender, EventArgs e)
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

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {           
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }
                var registroNota = ObtenerRegistroNotaSeleccionada();

                if (registroNota == null)
                {
                    return;
                }

                registroNota.Nota = float.Parse(tbxNotaFinal.Text);
                registroNotaBL.ActualizarRegistroNota(registroNota);

                tbxNotaFinal.Clear();
                this.MostrarMensaje("Nota actualizada.");
                
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }

        }

        private void dgvClases_DoubleClick(object sender, EventArgs e)
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

        private Clase ObtenerClaseSeleccionada()
        {
            if (dgvClases.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvClases.SelectedRows[0].Index;
            return listaClases[selectedIndex];
        }

        private void tbxBuscarEstudiantes_TextChanged(object sender, EventArgs e)
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

        private void dgvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var registroNota = ObtenerRegistroNotaSeleccionada();
                var clase = ObtenerClaseSeleccionada();

                if (registroNota == null || clase == null)
                {
                    return;
                }

                lblCurso.Text = clase.Curso.NombreCurso;
                lblNombre.Text = registroNota.Estudiante.Nombre;
                tbxNotaFinal.Text = registroNota.Nota.ToString();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }
    }
}
