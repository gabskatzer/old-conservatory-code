using System;

namespace Conservatorio.DATOS
{
    public class PagoMatricula
    {
        public virtual int IdPagoMatricula { get; set; }
        public virtual string Periodo { get; set; }
        public virtual int Año { get; set; }
        public virtual float Monto { get; set; }
        public virtual DateTime FechaPago { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual string Comentario { get; set; }
        public virtual string TipoPago { get; set; }
        public virtual string Referencia { get; set; }
    }
}
