using System;

namespace Conservatorio.DATOS
{
    public abstract class Persona
    {
        public virtual int IdPersona { get; set; }
        public virtual string Nombre { get; set; }
        public virtual long? Cedula { get; set; }
        public virtual bool Estado { get; set; }
        public virtual string Email { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Ocupacion { get; set; }
        public virtual string Imagen { get; set; }
        public virtual DateTime? FechaNacimiento { get; set; }
        public virtual int Telefono1 { get; set; }
        public virtual int? Telefono2 { get; set; }
        public virtual int? Telefono3 { get; set; }

    }
}
