using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class ClaseDS : IClaseDS
    {
        public void CrearClase(Clase clase)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(clase);
                conn.Flush();
            }
        }

        public void ModificarClase(Clase clase)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(clase);
                conn.Flush();
            }
        }

        public void EliminarClase(Clase clase)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Delete(clase);
                conn.Flush();
            }
        }

        public List<Clase> ObtenerClases(Expression<Func<Clase, bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<Clase>().Where(exp).ToList();
            }
        }
    }
}
