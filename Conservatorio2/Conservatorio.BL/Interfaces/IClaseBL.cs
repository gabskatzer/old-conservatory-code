using System.Collections.Generic;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IClaseBL
    {
        void CrearClase(Clase clase);
        void ModificarClase(Clase clase);
        void EliminarClase(Clase clase);
        List<Clase> ObtenerClases(string keyword);
        List<Clase> ObtenerClasesDisponibles(List<Clase> clasesDelPeriodo, List<Instrumento> instrumentos, List<Curso> cursosAprobados);
        List<Clase> ObtenerClases(int periodo, int ano, Profesor profesor, int aula);
        List<Clase> ObtenerClases(int periodo, int ano);
        List<Clase> ObtenerClasesConCupo(int periodo, int ano);
        List<Clase> ObtenerClases(int periodo, int ano, string keyword);
    }
}
