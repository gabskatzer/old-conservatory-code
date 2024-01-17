using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class ProfesorMap : SubclassMap<Profesor>
    {
        public ProfesorMap()
        {
            KeyColumn("IdProfesor");
            
            HasManyToMany(x => x.Instrumentos).Cascade.All().Table("ProfesorInstrumento").ParentKeyColumn("IdProfesor").ChildKeyColumn("IdInstrumento").Not.LazyLoad();
            HasMany(x => x.Clases).Cascade.All().KeyColumn("IdProfesor");
        }

    }
}
