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
        public static bool GetEnumDescription(Enum value, out string result)
        {
            result = null;
            FieldInfo info = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = info.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes?.Any() != null)
            {
                result = attributes.First().Description;
                return true;
            }
            return false;
        }

    }
}
