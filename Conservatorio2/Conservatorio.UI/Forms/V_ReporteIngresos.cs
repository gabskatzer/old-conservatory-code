using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_ReporteIngresos : Form
    {
        private readonly int ano;
        private readonly int? periodo;
        private readonly string mes;

        public V_ReporteIngresos(int ano, int? periodo, string mes)
        {
            InitializeComponent();

            this.ano = ano;
            this.periodo = periodo;
            this.mes = mes;
        }

        private void V_ReporteIngresos_Load(object sender, EventArgs e)
        {
            obtenerReporteIngresosTableAdapter.Fill(reportesDataSet.ObtenerReporteIngresos, ano, periodo, mes);
            reportViewer1.RefreshReport();
        }
    }
}
