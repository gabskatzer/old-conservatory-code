using System;
using System.Collections.Generic;
using Conservatorio.BL.Interfaces;
using Conservatorio.DATOS;
using Conservatorio.DS.Clases;
using Conservatorio.DS.Interfaces;

namespace Conservatorio.BL.Clases
{
    public class InstrumentoBL : IInstrumentoBL
    {
        private readonly IInstrumentoDS _instrumentoDs = new InstrumentoDS();

        internal InstrumentoBL()
        {
        }

        public void CrearInstrumento(Instrumento nuevoInstrumento)
        {
            // Agregar los 8 cursos para el instrumento
            nuevoInstrumento.Cursos = new List<Curso>();
            Curso requisito = null;
            for (var i = 1; i <= 8; i++)
            {
                var curso = new Curso
                {
                    Instrumento = nuevoInstrumento,
                    CursoRequisito = requisito,
                    Nivel = i,
                    NombreCurso = nuevoInstrumento.NombreInstrumento + " " + i
                };
                nuevoInstrumento.Cursos.Add(curso);

                requisito = curso;
            }

            _instrumentoDs.CrearInstrumento(nuevoInstrumento);
        }

        public List<Instrumento> ObtenerInstrumentos(string keyword)
        {
            return _instrumentoDs.ObtenerInstrumentos(x => x.NombreInstrumento.Contains(keyword));
        }

        public List<Instrumento> ObtenerInstrumentos()
        {
            return _instrumentoDs.ObtenerInstrumentos();
        }

        public void ModificarInstrumento(Instrumento instrumento)
        {
            // Modificar los cursos para el instrumento
            for (var i = 0; i < instrumento.Cursos.Count; i++)
            {
                instrumento.Cursos[i].NombreCurso = instrumento.NombreInstrumento + " " + (i + 1);
            }

            _instrumentoDs.ModificarInstrumento(instrumento);
        }
    }
}
