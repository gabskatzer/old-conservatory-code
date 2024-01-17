using System;

namespace Conservatorio.DATOS.Helpers
{
    public static class DateTimeHelper
    {
        public static class Constants
        {
            public const string HourMinutesMeridianFormat = "hh:mm tt";
            public const string HourMeridianFormat = "hh tt";
        }

        public static DateTime EnPunto(this DateTime dateTime)
        {
            return dateTime
                .AddMinutes(dateTime.Minute * -1)
                .AddSeconds(dateTime.Second * -1)
                .AddMilliseconds(dateTime.Millisecond * -1);
        }

        public static bool IsBetween(this DateTime dateTime, DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 <= dateTime && dateTime <= dateTime2;
        }

        public static DateTime FromString(string hora)
        {
            return DateTime.Parse(hora);
        }
    }
}
