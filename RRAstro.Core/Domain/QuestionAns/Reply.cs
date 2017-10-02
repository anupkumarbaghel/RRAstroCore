using System;
using System.Collections.Generic;
using System.Text;
using RRAstro.Core.Domain.Base;

namespace RRAstro.Core.Domain.QuestionAns
{
    public class Reply:AuditBaseDomain<long>
    {
        public string UserID { get; set; }
        public string ReplyDescription { get; set; }
    }
}
