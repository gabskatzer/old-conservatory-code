using Conservatorio.DATOS;
using System.Collections.Generic;

namespace Conservatorio.BL.Interfaces
{
    public interface IInstrumentoBL
    {
        void CrearInstrumento(Instrumento nuevoInstrumento);
        List<Instrumento> ObtenerInstrumentos(string keyword);
        List<Instrumento> ObtenerInstrumentos();

        void ModificarInstrumento(Instrumento instrumento);
    }
}
