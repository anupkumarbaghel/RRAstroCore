using RRAstro.Core.Domain.GetColorStone;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Repository.GetColorStone
{
    public interface IColorStoneReqRepository
    {
        IEnumerable<ColorStoneReq> GetAllColorStoneReqByUser(string userID);
        ColorStoneReq GetColorStoneReqData(long id);
        ColorStoneReq SaveColorStoneReq(ColorStoneReq colorStoneRequest);
        long DeleteColorStoneReq(long ID);
    }
}
