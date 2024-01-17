using System;

namespace Conservatorio.UI.FormModels
{
    public class ProfesorModel
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public long Cedula { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public string FechaNacimiento { get; set; }
        public int Telefono1 { get; set; }
        public int? Telefono2 { get; set; }
        public int? Telefono3 { get; set; }

    }
}
