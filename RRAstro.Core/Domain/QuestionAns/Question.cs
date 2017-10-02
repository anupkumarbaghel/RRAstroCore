using System;
using System.Collections.Generic;
using System.Text;
using RRAstro.Core.Domain.Base;

namespace RRAstro.Core.Domain.QuestionAns
{
    public class Question : AuditBaseDomain<long>
    {
        public Question()
        {
            ReplyList = new List<Reply>();
        }
        public string UserID { get; set; }
        public string QuestionDescription { get; set; }
        public ICollection<Reply> ReplyList { get; set; }
    }
}
