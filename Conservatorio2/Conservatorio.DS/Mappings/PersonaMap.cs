using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class PersonaMap : ClassMap<Persona>
    {
        public PersonaMap()
        {
            Id(x => x.IdPersona).GeneratedBy.Identity();
            Map(x => x.Cedula);
            Map(x => x.Direccion);
            Map(x => x.Imagen);
            Map(x => x.Email);
            Map(x => x.Estado).Not.Nullable();
            Map(x => x.FechaNacimiento);
            Map(x => x.Nombre).Not.Nullable();
            Map(x => x.Ocupacion);
            Map(x => x.Telefono1).Not.Nullable();
            Map(x => x.Telefono2);
            Map(x => x.Telefono3);
        }
    }
}
