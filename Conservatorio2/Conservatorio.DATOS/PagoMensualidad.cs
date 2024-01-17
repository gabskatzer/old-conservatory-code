using System;

namespace Conservatorio.DATOS
{
    public class PagoMensualidad
    {
        public virtual int IdPagoMensualidad { get; set; }
        public virtual float Monto { get; set; }
        public virtual float Multa { get; set; }
        public virtual DateTime FechaPago { get; set; }
        public virtual string Mes { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual string Comentario { get; set; }
        public virtual string TipoPago { get; set; }
        public virtual string Referencia { get; set; }
        public virtual int Ano { get; set; }
    }
}
