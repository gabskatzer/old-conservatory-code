using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Conservatorio.DATOS;

namespace Conservatorio.DS.Interfaces
{
    public interface IProfesorDS
    {
        void CrearProfesor(Profesor profesor);
        void ModificarProfesor(Profesor profesor);
        void EliminarProfesor(Profesor profesor);
        Profesor ObtenerProfesor(int idProfesor);
        List<Profesor> ObtenerProfesores(Expression<Func<Profesor, bool>> exp);
        List<Profesor> ObtenerProfesores();
    }
}
