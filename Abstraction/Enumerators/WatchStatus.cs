using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Enumerators
{
    public enum WatchStatus
    {
        [Description("")]
        UNCHANGED = 0,
        [Description("Watching")]
        WATCHING  = 1,
        [Description("On Hold")]
        ON_HOLD   = 2,
        [Description("Todo")]
        TODO      = 3,
        [Description("Droped")]
        DROPED    = 4,
    }
}
