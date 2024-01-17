using System.Collections.Generic;
using System.Linq;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class ProfesorBL : IProfesorBL
    {
        private readonly IProfesorDS _profesorDS = new ProfesorDS();

        internal ProfesorBL()
        {
        }

        public void CrearProfesor(Profesor profesor)
        {
            _profesorDS.CrearProfesor(profesor);
        }

        public void ModificarProfesor(Profesor profesor)
        {
            _profesorDS.ModificarProfesor(profesor);
        }

        public void EliminarProfesor(Profesor profesor)
        {
            _profesorDS.EliminarProfesor(profesor);
        }

        public List<Profesor> ObtenerProfesores(string keyword)
        {
            return _profesorDS.ObtenerProfesores(x => x.Nombre.Contains(keyword) || x.Cedula.ToString().Contains(keyword));
        }

        public List<Profesor> ObtenerProfesores()
        {
            return _profesorDS.ObtenerProfesores();
        }

        public List<Profesor> ObtenerProfesoresPorInstrumento(int idInstrumento)
        {
            return _profesorDS.ObtenerProfesores(p => p.Instrumentos.Select(i => i.IdInstrumento).Contains(idInstrumento));
        }
    }
}
