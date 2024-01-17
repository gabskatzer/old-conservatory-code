using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class V_ReporteEstudiante : Form
    {
        private readonly int idEstudiante;

        public V_ReporteEstudiante(int idEstudiante)
        {
            InitializeComponent();

            this.idEstudiante = idEstudiante;
        }

        private void V_ReporteEstudiante_Load(object sender, EventArgs e)
        {
            obtenerReporteEstudianteTableAdapter.Fill(reportesDataSet.ObtenerReporteEstudiante, idEstudiante);
            reportViewer1.RefreshReport();
        }
    }
}
