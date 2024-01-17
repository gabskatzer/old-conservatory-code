using System;
using System.Windows.Forms;

namespace Conservatorio.UI.Forms
{
    public partial class Inicio : Form
    {
        private void ActivateForm<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            Form newForm = Activator.CreateInstance<T>();
            newForm.MdiParent = this;
            newForm.Show();
        }

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void miEstudiantes_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Estudiantes>();
        }

        private void miProfesores_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Profesores>();
        }

        private void miInstrumentos_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Instrumentos>();
        }

        private void miCursos_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Cursos>();
        }

        private void miClases_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Clases>();
        }

        private void miRegistroNotas_Click(object sender, EventArgs e)
        {
            ActivateForm<V_RegistroNota>();
        }

        private void miMatricula_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Matricula>();
        }

        private void miMensualidad_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Mensualidad>();
        }


        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateForm<V_HistorialEstudiantes>();
        }

        private void IngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateForm<V_Ingresos>();
        }
    }
}
