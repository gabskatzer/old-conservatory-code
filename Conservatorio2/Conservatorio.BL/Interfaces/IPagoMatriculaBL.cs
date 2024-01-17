using System;
using Conservatorio.DATOS;

namespace Conservatorio.BL.Interfaces
{
    public interface IPagoMatriculaBL
    {
        void CrearPagoMatricula(PagoMatricula pagoMatricula);
        Tuple<int, int> ObtenerPeriodoActual();
    }
}
