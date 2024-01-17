using Conservatorio.BL.Interfaces;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class EncargadoBL : IEncargadoBL
    {
        private readonly IEncargadoDS _claseDs = new EncargadoDS();

        internal EncargadoBL()
        {
        }

    }
}
