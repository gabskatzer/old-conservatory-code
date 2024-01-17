using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using System;
using System.Windows.Forms;
using Conservatorio.BL;
using Conservatorio.UI.FormValidation;
using Conservatorio.UI.Helpers;

namespace Conservatorio.UI.Forms
{
    public partial class V_AgregarModificarInstrumento : Form
    {
        private readonly IInstrumentoBL instrumentoBL;
        private readonly V_Instrumentos vInst;
        private Instrumento instrumento;

        public V_AgregarModificarInstrumento(V_Instrumentos vInstrumentos, Instrumento instrumento = null)
        {
            InitializeComponent();
            ConfigurarValidacion();

            instrumentoBL = CapaLogica.InstrumentoBl;
            vInst = vInstrumentos;
            this.instrumento = instrumento;
        }

        private void ConfigurarValidacion()
        {
            var validadores = new[]
            {
                new Validador
                {
                    Control = tbxNombreInst,
                    MetodoValidacion = (out string errorMsg) => !tbxNombreInst.ValidarRequerido(out errorMsg)
                }
            };

            Validation.Config(errorProvider, validadores);
        }

        #region Action Methods

        private void btnAgregarInst_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateChildren())
                {
                    return;
                }

                if (instrumento == null)
                {
                    instrumento = new Instrumento();
                }
                instrumento.NombreInstrumento = tbxNombreInst.Text;
                instrumento.Individual = rbtnIndividual.Checked;

                if (instrumento.IdInstrumento == 0)
                {
                    instrumentoBL.CrearInstrumento(instrumento);
                }
                else
                {
                    instrumentoBL.ModificarInstrumento(instrumento);
                }

                Close();
                vInst.RefrescarInstrumentos();
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }

        #endregion

        private void V_AgregarModificarInstrumento_Load(object sender, EventArgs e)
        {
            try
            {

                Text = instrumento == null ? "Agregar Instrumento" : "Modificar Instrumento";

                if (instrumento == null)
                {
                    return;
                }

                tbxNombreInst.Text = instrumento.NombreInstrumento;
                rbtnIndividual.Checked = instrumento.Individual;
                rbtnGrupal.Checked = !instrumento.Individual;
            }
            catch (Exception ex)
            {
                this.MostrarError(ex);
            }
        }
    }
}
