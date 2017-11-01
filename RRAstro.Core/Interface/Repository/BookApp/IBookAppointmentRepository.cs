using RRAstro.Core.Domain.BookApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Repository.BookApp
{
   public interface IBookAppointmentRepository
    {
        IEnumerable<BookAppointment> GetAllBookedAppointmentByUser(string userID);
        BookAppointment GetAllBookedAppointment(long id);
        BookAppointment SaveAppointment(BookAppointment bApp);
        long DeleteAppointment(long ID);
    }
}
