using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class CursoMap : ClassMap<Curso>
    {
        public CursoMap()
        {
            Id(x => x.IdCurso).GeneratedBy.Identity();
            Map(x => x.NombreCurso).Not.Nullable();
            Map(x => x.Nivel).Not.Nullable();
            References(x => x.CursoRequisito).Column("IdRequisito");
            References(x => x.Instrumento).Column("IdInstrumento").Not.LazyLoad();
            HasMany(x => x.Clases).Cascade.All().KeyColumn("IdCurso");
        }
    }
}
