using RRAstro.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Domain.BookApp
{
   public class BookAppointment : AuditBaseDomain<long>
    {
        public string alternatePhoneNumber { get; set; }
        public DateTime dateOfAppointment { get; set; }
        public DateTime timeOfAppointment { get; set; }
        public string comments { get; set; }
        public string UserID { get; set; }

    }
}
