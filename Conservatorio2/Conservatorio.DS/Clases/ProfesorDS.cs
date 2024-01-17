using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Conservatorio.DS.Interfaces;
using Conservatorio.DATOS;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class ProfesorDS : IProfesorDS
    {
        public void CrearProfesor(Profesor profesor)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(profesor);
                conn.Flush();
            }
        }

        public void ModificarProfesor(Profesor profesor)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(profesor);
                conn.Flush();
            }
        }

        public void EliminarProfesor(Profesor profesor)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                profesor.Estado = false;
                conn.Update(profesor);
                conn.Flush();
            }
        }

        public Profesor ObtenerProfesor(int idProfesor)
        {
            throw new NotImplementedException();
        }

        public List<Profesor> ObtenerProfesores(Expression<Func<Profesor, bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Profesor>().Where(exp).ToList();
            }
        }

        public List<Profesor> ObtenerProfesores()
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Profesor>().ToList();
            }
        }
    }
}
