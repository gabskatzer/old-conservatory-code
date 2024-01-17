using Conservatorio.DATOS.Enums;
using Conservatorio.DATOS.Helpers;
using Conservatorio.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_Ingresos : Form
    {
        public V_Ingresos()
        {
            InitializeComponent();
        }

        private void V_Ingresos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPeriodos();
                CargarMeses();
                tbxAno.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {

                this.MostrarError(ex);
            }
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

        private void CargarMeses()
        {
            cbxMes.DataSource = EnumsHelper.GetEnumNamesAndDescriptions<MesesEnum>();
            cbxMes.ValueMember = "Key";
            cbxMes.DisplayMember = "Value";
        }

        private void rbtnPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            lblPeriodo.Visible = rbtnPeriodo.Checked;
            cbxPeriodo.Visible = rbtnPeriodo.Checked;

            lblMes.Visible = !rbtnPeriodo.Checked;
            cbxMes.Visible = !rbtnPeriodo.Checked;
        }

        private void rbtnMes_CheckedChanged(object sender, EventArgs e)
        {
            lblPeriodo.Visible = !rbtnMes.Checked;
            cbxPeriodo.Visible = !rbtnMes.Checked;

            lblMes.Visible = rbtnMes.Checked;
            cbxMes.Visible = rbtnMes.Checked;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            var ano = int.Parse(tbxAno.Text);
            var periodo = rbtnPeriodo.Checked ? (int?)cbxPeriodo.SelectedItem : null;
            var mes = rbtnMes.Checked ? cbxMes.SelectedValue.ToString() : null;

            var vIngresos = new V_ReporteIngresos(ano, periodo, mes);
            vIngresos.Show();
        }
    }
}
