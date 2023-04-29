using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Enumerators
{
    public static class Enumerators
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo info = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = info.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes == null)
            {
                return "";
            }

            return attributes.First().Description;

        }

    }
}
