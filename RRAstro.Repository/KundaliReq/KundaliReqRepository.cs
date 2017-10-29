using Microsoft.EntityFrameworkCore;
using RRAstro.Core.Domain.KundaliReq;
using RRAstro.Core.Interface.Repository.KundaliReq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace RRAstro.Repository.KundaliReq
{
    public class KundaliReqRepository : IKundaliReqRepository
    {
        RRAstroDBContext _context;
        public KundaliReqRepository(RRAstroDBContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public KundaliRequest SaveKundaliRequest(KundaliRequest kReq)
        {
            if (kReq.ID > 0)
            {
                _context.Update(kReq);
            }
            else
            {
                _context.Add(kReq);
            }

            _context.SaveChanges();
            return kReq;
        }

        public long DeleteKundaliReq(long ID)
        {
            KundaliRequest kReq = _context.KundaliReqs.FirstOrDefault(e => e.ID == ID);
            if (kReq == null) return -1;

            _context.KundaliReqs.Remove(kReq);
            _context.SaveChanges();
            return kReq.ID;
        }

        public IEnumerable<KundaliRequest> GetAllKundaliReqByUser(string userID)
        {
            return _context.KundaliReqs
               .Where(e => e.UserID == userID).ToList();
        }

        public KundaliRequest GetKundaliRequestData(long id)
        {
            return _context.KundaliReqs.FirstOrDefault(e => e.ID == id);
        }
    }
}
