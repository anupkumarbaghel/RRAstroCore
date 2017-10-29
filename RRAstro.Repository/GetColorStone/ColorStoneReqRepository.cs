using Microsoft.EntityFrameworkCore;
using RRAstro.Core.Domain.GetColorStone;
using RRAstro.Core.Interface.Repository.GetColorStone;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RRAstro.Repository.GetColorStone
{
    public class ColorStoneReqRepository : IColorStoneReqRepository
    {
        RRAstroDBContext _context;
        public ColorStoneReqRepository(RRAstroDBContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public ColorStoneReq SaveColorStoneReq(ColorStoneReq colorStoneRequest)
        {
            if (colorStoneRequest.ID > 0)
            {
                _context.Update(colorStoneRequest);
            }
            else
            {
                _context.Add(colorStoneRequest);
            }

            _context.SaveChanges();
            return colorStoneRequest;
        }

        public long DeleteColorStoneReq(long ID)
        {
            ColorStoneReq colorStoneReq = _context.ColorStoneReqs.FirstOrDefault(e => e.ID == ID);
            if (colorStoneReq == null) return -1;

            _context.ColorStoneReqs.Remove(colorStoneReq);
            _context.SaveChanges();
            return colorStoneReq.ID;
        }

        public IEnumerable<ColorStoneReq> GetAllColorStoneReqByUser(string userID)
        {
            return _context.ColorStoneReqs
               .Where(e => e.UserID == userID).ToList();
        }

        public ColorStoneReq GetColorStoneReqData(long id)
        {
            return _context.ColorStoneReqs.FirstOrDefault(e => e.ID == id);
        }
    }
}

