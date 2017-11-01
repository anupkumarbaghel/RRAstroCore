using RRAstro.Core.Domain.BookApp;
using RRAstro.Core.Interface.Application.BookApp;
using RRAstro.Core.Interface.Repository.BookApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Application.BookApp
{
   public class BookAppointmentApplication : IBookAppointmentApplication
    {
        IBookAppointmentRepository _bookAppService;
        public BookAppointmentApplication(IBookAppointmentRepository bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public IEnumerable<BookAppointment> GetAllBookedAppointmentByUser(string userID)
        {
            return _bookAppService.GetAllBookedAppointmentByUser(userID);
        }
        public BookAppointment GetAllBookedAppointment(long id)
        {
            return _bookAppService.GetAllBookedAppointment(id);
        }
        public BookAppointment SaveAppointment(BookAppointment bApp)
        {
            return _bookAppService.SaveAppointment(bApp);
        }
        public long DeleteAppointment(long ID)
        {
            return _bookAppService.DeleteAppointment(ID);
        }
    }
}

