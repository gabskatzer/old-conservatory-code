using System;
using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class EstudianteBL : IEstudianteBL
    {
        private readonly IEstudianteDS _estudianteDs = new EstudianteDS();

        internal EstudianteBL()
        {
        }

        public List<Estudiante> ObtenerEstudiantes(string keyword, bool incluirInactivos = true)
        {
            return _estudianteDs.ObtenerEstudiantes(x => x.Nombre.Contains(keyword) || x.Cedula.ToString().Contains(keyword) && (incluirInactivos || x.Estado));
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return _estudianteDs.ObtenerEstudiantes();
        }

        public void CrearEstudiante(Estudiante estudiante)
        {
            _estudianteDs.CrearEstudiante(estudiante);
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            _estudianteDs.EliminarEstudiante(estudiante);
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            _estudianteDs.ModificarEstudiante(estudiante);
        }

        public ContadorEstudiantes ObtenerContadorEstudiantes()
        {
            return _estudianteDs.ObtenerContadorEstudiantes();
        }
    }
}
