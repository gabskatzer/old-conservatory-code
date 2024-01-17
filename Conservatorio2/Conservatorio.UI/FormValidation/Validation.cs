using System.Windows.Forms;

namespace Conservatorio.UI.FormValidation
{
    public class Validation
    {
        public static void Config(ErrorProvider errorProvider, Validador[] validadores)
        {
            foreach (var validador in validadores)
            {
                validador.Control.Validating += (sender, e) =>
                {
                    string errorMsg;
                    var campo = (Control)sender;
                    if (validador.MetodoValidacion(out errorMsg))
                    {
                        e.Cancel = true;
                        errorProvider.SetError(campo, errorMsg);
                    }
                };

                validador.Control.Validated += (sender, e) =>
                {
                    errorProvider.SetError((Control)sender, string.Empty);
                };
            }
        }
    }
}
