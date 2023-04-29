using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Enumerators
{
    public enum ReadStatus
    {
        [Description("")]
        UNCHANGED  = 0,
        [Description("Read")]
        READ       = 1,
        [Description("Reading")]
        READING    = 2,
        [Description("To be read")]
        TO_BE_READ = 3,
        [Description("On Hold")]
        ON_HOLD    = 4,
        [Description("Droped")]
        DROPED     = 5,
    }
}
