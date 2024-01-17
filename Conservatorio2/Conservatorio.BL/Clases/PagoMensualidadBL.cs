using System;
using System.Configuration;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;
namespace Conservatorio.BL.Clases
{
    public class PagoMensualidadBL : IPagoMensualidadBL
    {
        private readonly IPagoMensualidadDS _pagoMensualidadDs = new PagoMensualidadDS();

        public void CrearPagoMensualidad(PagoMensualidad pagoMensualidad)
        {
            _pagoMensualidadDs.CrearPagoMensualidad(pagoMensualidad);
        }
        internal PagoMensualidadBL()
        {

        }
    }
}
