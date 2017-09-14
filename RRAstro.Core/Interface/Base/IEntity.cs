using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Base
{
    interface IEntity<DataType>
    {
        DataType ID { get; set; }
    }
}
