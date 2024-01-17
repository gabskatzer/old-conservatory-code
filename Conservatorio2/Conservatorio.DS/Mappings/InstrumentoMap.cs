using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class InstrumentoMap : ClassMap<Instrumento>
    {
        public InstrumentoMap()
        {
            Id(x => x.IdInstrumento).GeneratedBy.Identity();
            Map(x => x.NombreInstrumento).Not.Nullable();
            Map(x => x.Individual).Not.Nullable();
            HasManyToMany(x => x.Profesores).Cascade.All().Inverse().Table("ProfesorInstrumento").ParentKeyColumn("IdInstrumento").ChildKeyColumn("IdProfesor");
            HasManyToMany(x => x.Estudiantes).Cascade.All().Inverse().Table("EstudianteInstrumento").ParentKeyColumn("IdInstrumento").ChildKeyColumn("IdEstudiante");
            HasMany(x => x.Cursos).Cascade.All().KeyColumn("IdInstrumento").Not.LazyLoad();
        }
    }
}
