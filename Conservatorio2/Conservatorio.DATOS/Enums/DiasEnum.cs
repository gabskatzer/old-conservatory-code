using System.ComponentModel;

namespace Conservatorio.DATOS.Enums
{
    public enum DiasEnum
    {
        Lunes,
        Martes,
        [Description("Miércoles")] Miercoles,
        Jueves,
        Viernes,
        [Description("Sábado")] Sabado,
        Domingo
    }
}
