using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Conservatorio.DATOS;

namespace Conservatorio.DS.Interfaces
{
    public interface IRegistroNotaDS
    {
        void CrearRegistroNota(RegistroNota registroNota);
        void ModificarRegistroNota(RegistroNota registroNota);
        void EliminarRegistroNota(RegistroNota registroNota);
        List<RegistroNota> ObtenerRegistroNotas(Expression<Func<RegistroNota, bool>> exp);
    }
}
