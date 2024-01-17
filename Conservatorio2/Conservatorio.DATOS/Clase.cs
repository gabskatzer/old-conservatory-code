namespace Conservatorio.DATOS
{
    public class Clase
    {
        public virtual int IdClase { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual string Dia { get; set; }
        public virtual string HoraInicio { get; set; }
        public virtual string HoraFinal { get; set; }
        public virtual int Aula { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual int Periodo { get; set; }
        public virtual int Ano { get; set; }
    }
}
