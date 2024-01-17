using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IRegistroNotaBL
    {
        void CrearRegistroNota(RegistroNota registroNota);
        void ActualizarRegistroNota(RegistroNota registroNota);
        List<Curso> ObtenerCursosAprobados(Estudiante estudiante);
        List<RegistroNota> ObtenerRegistroNotas(Clase clase, string keyword);
    }
}
