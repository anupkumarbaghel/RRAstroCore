using RRAstro.Core.Domain.BookApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Application.BookApp
{
    public interface IBookAppointmentApplication
    {
        IEnumerable<BookAppointment> GetAllBookedAppointmentByUser(string userID);
        BookAppointment GetAllBookedAppointment(long id);
        BookAppointment SaveAppointment(BookAppointment bApp);
        long DeleteAppointment(long ID);
    }
}
