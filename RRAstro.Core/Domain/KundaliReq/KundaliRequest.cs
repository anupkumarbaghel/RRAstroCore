using System;
using System.Collections.Generic;
using System.Text;
using RRAstro.Core.Domain.Base;

namespace RRAstro.Core.Domain.KundaliReq
{
    public class KundaliRequest : AuditBaseDomain<long>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime timeOfBirth { get; set; }
        public string birthCity{ get; set; }
        public string birthCountry{ get; set; }
        public string UserID { get; set; }

    }
}
