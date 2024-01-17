using System;
using System.Configuration;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class PagoMatriculaBL : IPagoMatriculaBL
    {
        private readonly IPagoMatriculaDS _pagoMatriculaDs = new PagoMatriculaDS();

        internal PagoMatriculaBL()
        {
        }

        public void CrearPagoMatricula(PagoMatricula pagoMatricula)
        {
            _pagoMatriculaDs.CrearPagoMatricula(pagoMatricula);
        }

        public Tuple<int, int> ObtenerPeriodoActual()
        {
            var cantidadPeriodos = int.Parse(ConfigurationManager.AppSettings["cantidadPeriodos"]);
            var diasParaMatricular = int.Parse(ConfigurationManager.AppSettings["diasParaMatricular"]);

            var fechaActual = DateTime.Now;
            var fecha = fechaActual.AddDays(diasParaMatricular);

            decimal num = fecha.Month/(12/cantidadPeriodos);
            var periodo = Convert.ToInt32(Math.Ceiling(num));
            var ano = fecha.Year;

            return new Tuple<int, int>(periodo, ano);
        }
    }
}
