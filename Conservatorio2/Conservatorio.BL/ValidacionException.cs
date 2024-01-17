using System;
using System.Collections.Generic;

namespace Conservatorio.BL
{
    public class ValidacionException : Exception
    {
        public List<string> Mensajes { get; set; }

        public ValidacionException(List<string> mensajes)
        {
            Mensajes = mensajes;
        }

    }
}
