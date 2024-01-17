using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Conservatorio.DATOS;

namespace Conservatorio.DS.Interfaces
{
    public interface IClaseDS
    {
        void CrearClase(Clase clase);
        void ModificarClase(Clase clase);
        void EliminarClase(Clase clase);
        List<Clase> ObtenerClases(Expression<Func<Clase, bool>> exp);
    }
}
