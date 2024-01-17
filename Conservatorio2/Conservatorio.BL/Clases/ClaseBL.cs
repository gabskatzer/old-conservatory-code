using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;
using System.Linq;
using Conservatorio.DATOS.Helpers;
using System;

namespace Conservatorio.BL.Clases
{
    public class ClaseBL : IClaseBL
    {
        private readonly IClaseDS _claseDs = new ClaseDS();
        private readonly IRegistroNotaDS _RegistroNotaDs = new RegistroNotaDS();

        internal ClaseBL()
        {
        }

        private bool ValidarClase(Clase clase, out List<string> msjs)
        {
            var result = true;
            msjs = new List<string>();

            var clasesMismoDia = _claseDs.ObtenerClases(x => x.Periodo == clase.Periodo && x.Ano == clase.Ano && x.Dia == clase.Dia);
            var clasesMismoTiempo = clasesMismoDia
                .Where(x => !(DateTimeHelper.FromString(clase.HoraFinal) <= DateTimeHelper.FromString(x.HoraInicio)) && 
                            !(DateTimeHelper.FromString(clase.HoraInicio) >= DateTimeHelper.FromString(x.HoraFinal)))
                .ToList();

            var mismaAula = clasesMismoTiempo.Where(x => x.Aula == clase.Aula);
            if (mismaAula.Any(x => x.IdClase != clase.IdClase))
            {
                result = false;
                msjs.Add("La clase tiene un aula ya asignada en el mismo horario");
            }

            var mismoProfesor = clasesMismoTiempo.Where(x => x.Profesor.IdPersona == clase.Profesor.IdPersona);
            if (mismoProfesor.Any(x => x.IdClase != clase.IdClase))
            {
                result = false;
                msjs.Add("La clase tiene un profesor ya asignado en el mismo horario");
            }

            return result;
        }

        public void CrearClase(Clase clase)
        {
            List<string> mensajes;
            if (!ValidarClase(clase, out mensajes))
            {
                throw new ValidacionException(mensajes);
            }

            _claseDs.CrearClase(clase);
        }

        public void ModificarClase(Clase clase)
        {
            List<string> mensajes;
            if (!ValidarClase(clase, out mensajes))
            {
                throw new ValidacionException(mensajes);
            }

            _claseDs.ModificarClase(clase);
        }

        public void EliminarClase(Clase clase)
        {
            List<string> mensajes;
            if (!ValidarEliminarClase(clase, out mensajes))
            {
                throw new ValidacionException(mensajes);
            }

            _claseDs.EliminarClase(clase);
        }

        public List<Clase> ObtenerClases(string keyword)
        {
            return _claseDs.ObtenerClases(x => x.Profesor.Nombre.Contains(keyword) || x.Curso.NombreCurso.Contains(keyword) || x.Dia.Contains(keyword));
        }

        public List<Clase> ObtenerClasesDisponibles(List<Clase> clasesDelPeriodo, List<Instrumento> instrumentos, List<Curso> cursosAprobados)
        {
            var idsInstrumentos = instrumentos.Select(x => x.IdInstrumento);
            var idsCursosAprobados = cursosAprobados.Select(x => x.IdCurso);

            return clasesDelPeriodo
                .Where(x => idsInstrumentos.Contains(x.Curso.Instrumento.IdInstrumento))
                .Where(x => !idsCursosAprobados.Contains(x.Curso.IdCurso))
                .Where(x => x.Curso.CursoRequisito == null || idsCursosAprobados.Contains(x.Curso.CursoRequisito.IdCurso))
                .ToList();
        }

        public List<Clase> ObtenerClases(int periodo, int ano, Profesor profesor, int aula)
        {
            return _claseDs.ObtenerClases(x => x.Periodo == periodo && x.Ano == ano && (x.Profesor.IdPersona == profesor.IdPersona || x.Aula == aula));
        }

        public List<Clase> ObtenerClases(int periodo, int ano)
        {
            return _claseDs.ObtenerClases(x => x.Periodo == periodo && x.Ano == ano);
        }

        public List<Clase> ObtenerClases(int periodo, int ano, string keyword)
        {
            return _claseDs.ObtenerClases(x => x.Periodo == periodo && x.Ano == ano && (x.Profesor.Nombre.Contains(keyword) || x.Curso.NombreCurso.Contains(keyword) || x.Dia.Contains(keyword)));
        }

        public List<Clase> ObtenerClasesConCupo(int periodo, int ano)
        {
            var clasesMatriculadas = _RegistroNotaDs.ObtenerRegistroNotas(x => x.Clase.Periodo == periodo && x.Clase.Ano == ano).Select(x => x.Clase.IdClase);
            return _claseDs.ObtenerClases(x => x.Periodo == periodo && x.Ano == ano && (!x.Curso.Instrumento.Individual || !clasesMatriculadas.Contains(x.IdClase)));
        }

        private bool ValidarEliminarClase(Clase clase, out List<string> msjs)
        {
            var result = true;
            msjs = new List<string>();

            var registroNotas = _RegistroNotaDs.ObtenerRegistroNotas(x => x.Clase.IdClase == clase.IdClase);
            if (registroNotas.Any())
            {
                result = false;
                msjs.Add("La clase ya tiene estudiante(s) matriculado(s).");
            }
            
            return result;
        }
    }
}
