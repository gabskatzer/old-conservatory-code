using Conservatorio.DATOS;

namespace Conservatorio.DS.Interfaces
{
    public interface IEncargadoDS
    {
        void CrearEncargado(Encargado nuevoEncargado);
        void ModificarEncargado(Encargado encargado);
        void EliminarEncargado(int idEncargado);
        Encargado ObtenerEncargado(int idEncargado);
    }
}
