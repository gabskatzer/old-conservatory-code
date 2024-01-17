using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class CursoDS : ICursoDS
    {
        public void CrearCurso(Curso curso)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(curso);
                conn.Flush();
            }
        }

        public void ModificarCurso(Curso curso)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(curso);
                conn.Flush();
            }
        }

        public void EliminarCurso(Curso curso)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Delete(curso);
                conn.Flush();
            }
        }

        public List<Curso> ObtenerCursos()
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Curso>().ToList();
            }
        }

        public List<Curso> ObtenerCursos(Expression<Func<Curso, bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Curso>().Where(exp).ToList();
            }
        }
    }
}
