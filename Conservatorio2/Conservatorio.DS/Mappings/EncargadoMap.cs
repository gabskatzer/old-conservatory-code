using Conservatorio.DATOS;
using FluentNHibernate.Mapping;

namespace Conservatorio.DS.Mappings
{
    public class EncargadoMap : SubclassMap<Encargado>
    {
        public EncargadoMap()
        {
            KeyColumn("IdEncargado");
            Map(x => x.Parentesco).Not.Nullable();
        }
    }
}
