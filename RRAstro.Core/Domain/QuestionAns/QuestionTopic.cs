using RRAstro.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Domain.QuestionAns
{
    public class QuestionTopic : AuditBaseDomain<long>
    {
        public QuestionTopic()
        {
            QuestionList = new List<Question>();
        }
        public string UserID { get; set; }
        public ICollection<Question> QuestionList { get; set; }
    }
}
