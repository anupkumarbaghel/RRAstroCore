using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Base
{
    interface IHasModifiedBy
    {
        string CreatedBy { get; set; }
    }
}
