using System;
using Conservatorio.DATOS.Enums;

namespace Conservatorio.UI.FormModels
{
    public class DiaHorasModel
    {
        public DiasEnum Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
    }
}
