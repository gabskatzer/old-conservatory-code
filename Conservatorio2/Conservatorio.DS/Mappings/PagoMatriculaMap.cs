using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class PagoMatriculaMap : ClassMap<PagoMatricula>
    {
        public PagoMatriculaMap()
        {
            Id(x => x.IdPagoMatricula).GeneratedBy.Identity();
            Map(x => x.Periodo).Not.Nullable();
            Map(x => x.Año).Not.Nullable();
            Map(x => x.Monto).Not.Nullable();
            Map(x => x.FechaPago).Not.Nullable();
            Map(x => x.Comentario);
            Map(x => x.Referencia);
            Map(x => x.TipoPago).Not.Nullable();
            References(x => x.Estudiante).Column("IdEstudiante");
        }
    }
}
