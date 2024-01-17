using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Conservatorio.DATOS;
using Conservatorio.DS.Interfaces;
using NHibernate.Linq;

namespace Conservatorio.DS.Clases
{
    public class RegistroNotaDS : IRegistroNotaDS
    {
        public void CrearRegistroNota(RegistroNota registroNota)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Save(registroNota);
                conn.Flush();
            }
        }

        public void ModificarRegistroNota(RegistroNota registroNota)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Update(registroNota);
                conn.Flush();
            }
        }

        public void EliminarRegistroNota(RegistroNota registroNota)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                conn.Delete(registroNota);
                conn.Flush();
            }
        }

        public List<RegistroNota> ObtenerRegistroNotas(Expression<Func<RegistroNota, bool>> exp)
        {
            using (var conn = Conexion.EstablecerConexion())
            {
                return conn.Query<RegistroNota>().Where(exp).ToList();
            }
        }
    }

}
