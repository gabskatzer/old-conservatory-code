using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class EstudianteMap : SubclassMap<Estudiante>
    {
        public EstudianteMap()
        {
            KeyColumn("IdEstudiante");
            Map(x => x.Tipo).Not.Nullable();
            Map(x => x.GradoAcademico);
            References(x => x.Encargado).Column("IdEncargado").Cascade.All().Not.LazyLoad();
            HasManyToMany(x => x.Instrumentos).Cascade.All().Table("EstudianteInstrumento").ParentKeyColumn("IdEstudiante").ChildKeyColumn("IdInstrumento").Not.LazyLoad();
        }
    }
}
