using System.Windows.Forms;

namespace Conservatorio.UI.FormValidation
{
    public class Validador
    {
        public Control Control { get; set; }

        public DelValidador MetodoValidacion { get; set; }

        public delegate bool DelValidador(out string errorMsg);
    }
}
