using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface ICursoBL
    {
        void CrearCurso(Curso curso);
        void ModificarCurso(Curso curso);
        void EliminarCurso(Curso curso);
        List<Curso> ObtenerCursos();
        List<Curso> ObtenerCursosPorInstrumento(int idInstrumento);
    }
}
