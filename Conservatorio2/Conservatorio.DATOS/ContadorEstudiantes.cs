using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatorio.DATOS
{
    public class ContadorEstudiantes
    {
        public int Activos { get; set; }
        public int Inactivos { get; set; }
        public int Totales { get { return Activos + Inactivos; } }
    }
}
