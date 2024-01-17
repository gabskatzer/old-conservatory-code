using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class RegistroNotaBL : IRegistroNotaBL
    {
        private readonly IRegistroNotaDS _registroNotaDs = new RegistroNotaDS();

        internal RegistroNotaBL()
        {
        }

        public void ActualizarRegistroNota(RegistroNota registroNota)
        {
            _registroNotaDs.ModificarRegistroNota(registroNota);
        }

        public void CrearRegistroNota(RegistroNota registroNota)
        {
            _registroNotaDs.CrearRegistroNota(registroNota);
        }

        public List<Curso> ObtenerCursosAprobados(Estudiante estudiante)
        {
            var notaMinima = int.Parse(ConfigurationManager.AppSettings["notaMinima"]);
            return _registroNotaDs.ObtenerRegistroNotas(x => x.Estudiante.IdPersona == estudiante.IdPersona && x.Nota >= notaMinima)
                .Select(x => x.Clase.Curso)
                .ToList();
        }

        public List<RegistroNota> ObtenerRegistroNotas(Clase clase, string keyword)
        {
            return _registroNotaDs.ObtenerRegistroNotas(x => x.Clase.IdClase == clase.IdClase && x.Estudiante.Nombre.Contains(keyword));
                
        }
    }
}
