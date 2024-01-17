using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Conservatorio.UI.FormValidation
{
    public static class ValidationExtensions
    {
        private const string RegexEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        public static bool ValidarRequerido(this Control control, out string msg)
        {
            var value = control.Text;
            var esValido = !string.IsNullOrWhiteSpace(value);
            msg = esValido ? null : "El campo es requerido";
            return esValido;
        }

        public static bool ValidarEntero(this Control control, out string msg)
        {
            var esValido = true;
            msg = null;

            long n;
            var value = control.Text;
            if (!string.IsNullOrEmpty(value) && !long.TryParse(value, out n))
            {
                esValido = false;
                msg = "El campo debe ser un numero";
            }

            return esValido;
        }

        public static bool ValidarLargo(this Control control, int largo, out string msg)
        {
            var value = control.Text;
            var esValido = string.IsNullOrEmpty(value) || value.Length == largo;
            msg = esValido ? null : string.Format("El campo debe tener {0} caracteres", largo);
            return esValido;
        }

        public static bool ValidarLargo(this Control control, int min, int max, out string msg)
        {
            var value = control.Text;
            var esValido = string.IsNullOrEmpty(value) || (min <= value.Length && value.Length <= max);
            msg = esValido ? null : string.Format("El campo debe tener entre {0} y {1} caracteres", min, max);
            return esValido;
        }

        public static bool ValidarEmail(this Control control, out string msg)
        {
            var value = control.Text;
            var esValido = string.IsNullOrEmpty(value) || Regex.IsMatch(value, RegexEmail, RegexOptions.IgnoreCase);
            msg = esValido ? null : "El campo no corresponde a un correo valido";
            return esValido;
        }

        public static bool ValidarRequerido(this DataGridView dgv, out string msg)
        {
            var esValido = dgv.SelectedCells.Cast<DataGridViewCell>().Count(x => x.ColumnIndex > 0) > 0;
            msg = esValido ? null : "El campo es requerido";
            return esValido;
        }

        public static bool ValidarRango(this DataGridView dgv, out string msg)
        {
            var celdasSeleccionadas = dgv.SelectedCells.Cast<DataGridViewCell>().ToList();
            var idx = celdasSeleccionadas.First().ColumnIndex;
            var esValido = celdasSeleccionadas.All(x => x.ColumnIndex == idx);
            msg = esValido ? null : "El rango es invalido";
            return esValido;
        }
    }
}
