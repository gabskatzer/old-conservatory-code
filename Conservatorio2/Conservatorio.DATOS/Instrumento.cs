using System.Collections.Generic;

namespace Conservatorio.DATOS
{
    public class Instrumento
    {
        public virtual int IdInstrumento { get; set; }
        public virtual string NombreInstrumento { get; set; }
        public virtual bool Individual { get; set; }
        public virtual IList<Profesor> Profesores { get; set; }
        public virtual IList<Estudiante> Estudiantes { get; set; }
        public virtual IList<Curso> Cursos { get; set; }
    }
}
