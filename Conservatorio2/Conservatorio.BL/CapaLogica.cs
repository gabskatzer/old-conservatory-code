using Conservatorio.BL.Clases;
using Conservatorio.BL.Interfaces;

namespace Conservatorio.BL
{
    public class CapaLogica
    {
        private static IClaseBL _claseBl;
        public static IClaseBL ClaseBl => _claseBl ?? (_claseBl = new ClaseBL());

        private static ICursoBL _cursoBl;
        public static ICursoBL CursoBl => _cursoBl ?? (_cursoBl = new CursoBL());

        private static IEncargadoBL _encargadoBl;
        public static IEncargadoBL EncargadoBl => _encargadoBl ?? (_encargadoBl = new EncargadoBL());

        private static IEstudianteBL _estudianteBl;
        public static IEstudianteBL EstudianteBl => _estudianteBl ?? (_estudianteBl = new EstudianteBL());

        private static IInstrumentoBL _instrumentoBl;
        public static IInstrumentoBL InstrumentoBl => _instrumentoBl ?? (_instrumentoBl = new InstrumentoBL());

        private static IPagoMatriculaBL _pagoMatriculaBl;
        public static IPagoMatriculaBL PagoMatriculaBl => _pagoMatriculaBl ?? (_pagoMatriculaBl = new PagoMatriculaBL());

        private static IPagoMensualidadBL _pagoMensualidadBl;
        public static IPagoMensualidadBL PagoMensualidadBl => _pagoMensualidadBl ?? (_pagoMensualidadBl = new PagoMensualidadBL());

        private static IProfesorBL _profesorBl;
        public static IProfesorBL ProfesorBl => _profesorBl ?? (_profesorBl = new ProfesorBL());

        private static IRegistroNotaBL _registroNotaBl;
        public static IRegistroNotaBL RegistroNotaBl => _registroNotaBl ?? (_registroNotaBl = new RegistroNotaBL());
    }
}
