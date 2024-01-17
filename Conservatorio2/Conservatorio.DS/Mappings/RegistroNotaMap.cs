using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class RegistroNotaMap : ClassMap<RegistroNota>
    {
        public RegistroNotaMap()
        {
            Id(x => x.IdRegistroNota).GeneratedBy.Identity();
            Map(x => x.Nota);
            References(x => x.Estudiante).Column("IdEstudiante").Not.LazyLoad();
            References(x => x.Clase).Column("IdClase").Not.LazyLoad();
        }
    }
}
