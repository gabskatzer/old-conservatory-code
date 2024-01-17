namespace Conservatorio.DATOS
{
    public class RegistroNota
    {
        public virtual int IdRegistroNota { get; set; }
        public virtual Clase Clase { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual float? Nota { get; set; }
    }
}
