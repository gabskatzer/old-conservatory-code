using System;
using System.Collections.Generic;
using System.Linq;
using Conservatorio.DS.Interfaces;
using Conservatorio.DATOS;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class EstudianteDS : IEstudianteDS
    {
        public void CrearEstudiante(Estudiante nuevoEstudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(nuevoEstudiante);
                conn.Flush();
            }
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(estudiante);
                conn.Flush();
            }
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                estudiante.Estado = false;
                conn.Update(estudiante);
                conn.Flush();
            }
        }

        public Estudiante ObtenerEstudiante(int idEstudiante)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Get<Estudiante>(idEstudiante);
            }
        }

        public List<Estudiante> ObtenerEstudiantes(Expression<Func<Estudiante, bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Estudiante>().Where(exp).ToList();
            }
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            throw new NotImplementedException();
        }

        public ContadorEstudiantes ObtenerContadorEstudiantes()
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                var estudiantes = conn.Query<Estudiante>();
                return new ContadorEstudiantes
                {
                    Activos = estudiantes.Count(x => x.Estado),
                    Inactivos = estudiantes.Count(x => !x.Estado)
                };
            }
        }
    }
}
