using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Conservatorio.DS.Interfaces
{
    public interface IInstrumentoDS
    {
        void CrearInstrumento(Instrumento nuevoInstrumento);
        void ModificarInstrumento(Instrumento instrumento);
        Instrumento ObtenerInstrumento(int idInstrumento);
        List<Instrumento> ObtenerInstrumentos(Expression<Func<Instrumento, bool>> exp);
        List<Instrumento> ObtenerInstrumentos();
    }
}
