using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_HistorialEstudiantes : Form
    {
        private readonly IEstudianteBL estudianteBL;

        private List<Estudiante> listaEstudiantes;
        public V_HistorialEstudiantes()
        {
            InitializeComponent();

            estudianteBL = CapaLogica.EstudianteBl;
        }

        private void V_HistorialEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarEstudiantes();
                CargarTotales();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void RefrescarEstudiantes()
        {

            var keyword = tbxBuscarEstudiantes.Text;
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
                Telefono1Encargado = x.Encargado == null ? (int?)null : x.Encargado.Telefono1,
                Telefono2Encargado = x.Encargado == null ? null : x.Encargado.Telefono2,
                Telefono3Encargado = x.Encargado == null ? null : x.Encargado.Telefono3,
                EmailEncargado = x.Encargado == null ? string.Empty : x.Encargado.Email
            }).ToList();
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

        private void CargarTotales()
        {
            var contadorEstudiantes = estudianteBL.ObtenerContadorEstudiantes();

            lblActivo.Text = contadorEstudiantes.Activos.ToString();
            lblInactivo.Text = contadorEstudiantes.Inactivos.ToString();
            lblTotal.Text = contadorEstudiantes.Totales.ToString();
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

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            var estudiante = ObtenerEstudianteSeleccionado();
            if (estudiante == null)
            {
                return;
            }

            var vReporteEstudiante = new V_ReporteEstudiante(estudiante.IdPersona);
            vReporteEstudiante.Show();
        }
    }
}
