using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.UI.FormModels;
using Conservatorio.UI.Helpers;

namespace Conservatorio.UI.Forms
{
    public partial class V_Clases : Form
    {
        private readonly IClaseBL claseBL;
        private List<Clase> listaClases;

        public V_Clases()
        {
            InitializeComponent();

            claseBL = CapaLogica.ClaseBl;
        }
        
        public void RefrescarClases()
        {
            var keyword = tbxBuscar.Text;
            listaClases = claseBL.ObtenerClases(keyword);
            dgvClases.DataSource = listaClases.Select(x => new ClaseModel
            {
                Profesor = x.Profesor.Nombre,
                Curso = x.Curso.NombreCurso,
                Dia = x.Dia,
                HoraInicio = x.HoraInicio,
                HoraFinal = x.HoraFinal,
	            Aula = x.Aula,
	            Periodo = string.Format("{0}-{1}", x.Ano, x.Periodo)
            }).ToList();
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

        #region Action Methods

        private void V_Clases_Load(object sender, EventArgs e)
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

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new V_AgregarModificarClase(this, null);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var clase = ObtenerClaseSeleccionada();
                if (clase == null)
                {
                    return;
                }

                Form form = new V_AgregarModificarClase(this, clase);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var clase = ObtenerClaseSeleccionada();
                if (clase == null)
                {
                    return;
                }

                claseBL.EliminarClase(clase);
                RefrescarClases();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

    }
}
