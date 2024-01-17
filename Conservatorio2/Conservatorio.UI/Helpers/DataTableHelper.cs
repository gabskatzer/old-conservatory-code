using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Conservatorio.DATOS;
using Conservatorio.DATOS.Enums;
using Conservatorio.DATOS.Helpers;

namespace Conservatorio.UI.Helpers
{
    public static class DataTableHelper
    {
        public static DataTable ToDataTable(this List<Clase> clases)
        {
            var result = new DataTable();

            // Agregar encabezados
            var dias = Enum.GetValues(typeof(DiasEnum)).Cast<DiasEnum>().Select(x => x.GetEnumDescription());
            result.Columns.Add("Horario");
            foreach (var dia in dias)
            {
                result.Columns.Add(dia);
            }

            // Agregar informacion
            for (var i = 8; i < 21; i++)
            {
                var now = DateTime.Now;
                var horaInicio = new DateTime(now.Year, now.Month, now.Day, i, 0, 0);
                var horaSalida = horaInicio.AddHours(1);
                var horario = string.Format("{0} - {1}", horaInicio.ToString(DateTimeHelper.Constants.HourMeridianFormat), horaSalida.ToString(DateTimeHelper.Constants.HourMeridianFormat));

                var clasesMismoHorario = clases.Where(x => DateTimeHelper.FromString(x.HoraInicio) <= horaInicio && DateTimeHelper.FromString(x.HoraFinal) >= horaSalida).ToList();
                var clasesLunes = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Lunes.ToString()).Select(x => x.ToFormattedString());
                var clasesMartes = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Martes.ToString()).Select(x => x.ToFormattedString());
                var clasesMiercoles = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Miercoles.ToString()).Select(x => x.ToFormattedString());
                var clasesJueves = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Jueves.ToString()).Select(x => x.ToFormattedString());
                var clasesViernes = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Viernes.ToString()).Select(x => x.ToFormattedString());
                var clasesSabado = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Sabado.ToString()).Select(x => x.ToFormattedString());
                var clasesDomingo = clasesMismoHorario.Where(x => x.Dia == DiasEnum.Domingo.ToString()).Select(x => x.ToFormattedString());
                result.Rows.Add(horario, string.Join(Environment.NewLine, clasesLunes), string.Join(Environment.NewLine, clasesMartes), string.Join(Environment.NewLine, clasesMiercoles), string.Join(Environment.NewLine, clasesJueves), string.Join(Environment.NewLine, clasesViernes), string.Join(Environment.NewLine, clasesSabado), string.Join(Environment.NewLine, clasesDomingo));
            }

            return result;
        }

        private static string ToFormattedString(this Clase clase)
        {
            const string format = "{0} ({1}) - Aula{2}";
            return string.Format(format, clase.Curso.NombreCurso, clase.Profesor.Nombre, clase.Aula);
        }
    }
}
