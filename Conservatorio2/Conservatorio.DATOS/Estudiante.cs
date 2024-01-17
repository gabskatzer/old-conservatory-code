using System.Collections.Generic;

namespace Conservatorio.DATOS
{
    public class Estudiante : Persona
    {
        public virtual Encargado Encargado { get; set; }
        public virtual string Tipo { get; set; }
        public virtual IList<Instrumento> Instrumentos { get; set; }
        public virtual string GradoAcademico { get; set; }
    }
}
