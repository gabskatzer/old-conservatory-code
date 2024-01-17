using Conservatorio.DS.Interfaces;
using Conservatorio.DATOS;

namespace Conservatorio.DS.Clases
{
    public class PagoMensualidadDS : IPagoMensualidadDS
    {
        public void CrearPagoMensualidad(PagoMensualidad pagoMensualidad)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(pagoMensualidad);
                conn.Flush();
            }
        }
    }
}
