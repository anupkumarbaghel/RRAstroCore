﻿using RRAstro.Core.Domain.Base;
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
       public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime timeOfBirth { get; set; }
        public string birthCity { get; set; }
        public string birthCountry { get; set; }
        public string UserID { get; set; }
        public ICollection<Question> QuestionList { get; set; }
    }
}
