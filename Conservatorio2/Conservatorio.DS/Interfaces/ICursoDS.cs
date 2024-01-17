using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Conservatorio.DATOS;

namespace Conservatorio.DS.Interfaces
{
    public interface ICursoDS
    {
        void CrearCurso(Curso curso);
        void ModificarCurso(Curso curso);
        void EliminarCurso(Curso curso);
        List<Curso> ObtenerCursos();
        List<Curso> ObtenerCursos(Expression<Func<Curso, bool>> exp);
    }
}
