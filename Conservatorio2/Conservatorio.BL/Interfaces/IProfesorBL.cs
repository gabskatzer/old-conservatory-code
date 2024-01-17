using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IProfesorBL
    {
        void CrearProfesor(Profesor profesor);
        void ModificarProfesor(Profesor profesor);
        void EliminarProfesor(Profesor profesor);
        List<Profesor> ObtenerProfesores(string keyword);
        List<Profesor> ObtenerProfesores();
        List<Profesor> ObtenerProfesoresPorInstrumento(int idInstrumento);
    }
}
