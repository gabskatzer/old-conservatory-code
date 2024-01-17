using Conservatorio.BL.Interfaces;
using Conservatorio.UI.FormModels;
using System;
using System.Linq;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.UI.Helpers;
using Conservatorio.DATOS;
using System.Collections.Generic;

namespace Conservatorio.UI.Forms
{
    public partial class V_Instrumentos : Form
    {
        private readonly IInstrumentoBL instrumentosBL;
        private List<Instrumento> listaInstrumentos;

        public V_Instrumentos()
        {
            InitializeComponent();
            instrumentosBL = CapaLogica.InstrumentoBl;
        }

        public void RefrescarInstrumentos()
        {
            var keyword = tbxBuscar.Text;
            listaInstrumentos = instrumentosBL.ObtenerInstrumentos(keyword);
            dgvInstrumentos.DataSource = listaInstrumentos.Select(x => new InstrumentoModel
            {
                IdInstrumento = x.IdInstrumento,
                NombreInstrumento = x.NombreInstrumento,
                Tipo = x.Individual ? "Individual" : "Grupal"
            }).ToList();
        }

        private Instrumento ObtenerInstrumentoSeleccionado()
        {
            if (dgvInstrumentos.SelectedRows.Count == 0)
            {
                return null;
            }

            var selectedIndex = dgvInstrumentos.SelectedRows[0].Index;
            return listaInstrumentos[selectedIndex];
        }

        #region Action Events

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new V_AgregarModificarInstrumento(this);
                f.ShowDialog();
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
                RefrescarInstrumentos();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        private void V_Instrumentos_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarInstrumentos();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var instrumentoSeleccionado = ObtenerInstrumentoSeleccionado();
                if (instrumentoSeleccionado == null)
                {
                    return;
                }
                Form f = new V_AgregarModificarInstrumento(this, instrumentoSeleccionado);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }
    }
    
}
