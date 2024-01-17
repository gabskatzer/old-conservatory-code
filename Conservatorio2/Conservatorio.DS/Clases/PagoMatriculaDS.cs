using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.DS.Clases
{
    public class PagoMatriculaDS : IPagoMatriculaDS
    {
        public void CrearPagoMatricula(PagoMatricula pagoMatricula)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(pagoMatricula);
                conn.Flush();
            }
        }
    }
}
