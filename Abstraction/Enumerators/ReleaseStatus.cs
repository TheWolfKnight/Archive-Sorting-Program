using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Enumerators
{
    public enum ReleaseStatus
    {
        [Description("")]
        UNCHANGED  = 0,
        [Description("Unreleased")]
        UNRELEASED = 1,
        [Description("Releasing")]
        RELEASING  = 2,
        [Description("Done")]
        DONE       = 3,
        [Description("Droped")]
        DROPED     = 4,
    }
}
