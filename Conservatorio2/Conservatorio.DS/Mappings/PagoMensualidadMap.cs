using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class PagoMensualidadMap : ClassMap<PagoMensualidad>
    {
        public PagoMensualidadMap()
        {
            Id(x => x.IdPagoMensualidad).GeneratedBy.Identity();
            Map(x => x.Monto).Not.Nullable();
            Map(x => x.FechaPago).Not.Nullable();
            Map(x => x.Mes).Not.Nullable();
            Map(x => x.Multa).Not.Nullable();
            Map(x => x.Referencia);
            Map(x => x.Comentario);
            Map(x => x.TipoPago).Not.Nullable();
            Map(x => x.Ano).Not.Nullable();
            References(x => x.Estudiante).Column("IdEstudiante");


        }
    }
}
