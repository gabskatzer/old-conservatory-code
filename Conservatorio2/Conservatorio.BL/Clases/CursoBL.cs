using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;
using System.Linq;

namespace Conservatorio.BL.Clases
{
    public class CursoBL : ICursoBL
    {
        private readonly ICursoDS _cursoDs = new CursoDS();

        internal CursoBL()
        {
        }

        public void CrearCurso(Curso curso)
        {
            _cursoDs.CrearCurso(curso);
        }

        public void ModificarCurso(Curso curso)
        {
            _cursoDs.ModificarCurso(curso);
        }

        public void EliminarCurso(Curso curso)
        {
            List<string> mensajes;
            if (!ValidarEliminarCurso(curso, out mensajes))
            {
                throw new ValidacionException(mensajes);
            }

            _cursoDs.EliminarCurso(curso);
        }

        public List<Curso> ObtenerCursos()
        {
            return _cursoDs.ObtenerCursos();
        }

        public List<Curso> ObtenerCursosPorInstrumento(int idInstrumento)
        {
            return _cursoDs.ObtenerCursos(x => x.Instrumento.IdInstrumento == idInstrumento);
        }

        private bool ValidarEliminarCurso(Curso curso, out List<string> msjs)
        {
            var result = true;
            msjs = new List<string>();

            var cursos = ObtenerCursos();

            if (cursos.Any(x => x.CursoRequisito != null && x.CursoRequisito.IdCurso == curso.IdCurso))
            {
                result = false;
                msjs.Add("El curso que desea eliminar es requisito de otro.");
            }

            return result;
        }
    }
}
