using Conservatorio.DATOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Conservatorio.DS.Interfaces
{
    public interface IEstudianteDS
    {
        void CrearEstudiante(Estudiante nuevoEstudiante);
        void ModificarEstudiante(Estudiante estudiante);
        void EliminarEstudiante(Estudiante nuevoEstudiante);
        Estudiante ObtenerEstudiante(int idEstudiante);
        List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp);
        List<Estudiante> ObtenerEstudiantes();
        ContadorEstudiantes ObtenerContadorEstudiantes();
    }
}
