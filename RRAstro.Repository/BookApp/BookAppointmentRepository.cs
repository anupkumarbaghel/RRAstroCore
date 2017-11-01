using Microsoft.EntityFrameworkCore;
using RRAstro.Core.Domain.BookApp;
using RRAstro.Core.Interface.Repository.BookApp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RRAstro.Repository.BookApp
{
    public class BookAppointmentRepository : IBookAppointmentRepository
    {
        RRAstroDBContext _context;
        public BookAppointmentRepository(RRAstroDBContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public BookAppointment SaveAppointment(BookAppointment bApp)
        {
            if (bApp.ID > 0)
            {
                _context.Update(bApp);
            }
            else
            {
                _context.Add(bApp);
            }

            _context.SaveChanges();
            return bApp;
        }

        public long DeleteAppointment(long ID)
        {
            BookAppointment bApp = _context.BookAppointments.FirstOrDefault(e => e.ID == ID);
            if (bApp == null) return -1;

            _context.BookAppointments.Remove(bApp);
            _context.SaveChanges();
            return bApp.ID;
        }

        public IEnumerable<BookAppointment> GetAllBookedAppointmentByUser(string userID)
        {
            return _context.BookAppointments
               .Where(e => e.UserID == userID).ToList();
        }

        public BookAppointment GetAllBookedAppointment(long id)
        {
            return _context.BookAppointments.FirstOrDefault(e => e.ID == id);
        }
    }
}
