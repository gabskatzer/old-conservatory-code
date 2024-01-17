using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Conservatorio.DATOS.Helpers
{
    public static class EnumsHelper
    {
        public static string GetEnumDescription(this Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static List<KeyValuePair<string, string>> GetEnumNamesAndDescriptions<T>()
        {
            var enumType = typeof(T);

            if (enumType.BaseType != typeof(Enum))
            {
                throw new ArgumentException("T is not System.Enum");
            }

            var result = new List<KeyValuePair<string, string>>();

            foreach (var e in Enum.GetValues(enumType))
            {
                var fi = e.GetType().GetField(e.ToString());
                var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                var name = e.ToString();
                var description = attributes.Length > 0 ? attributes[0].Description : name;
                var kv = new KeyValuePair<string, string>(name, description);
                result.Add(kv);
            }

            return result;
        }

    }
}
