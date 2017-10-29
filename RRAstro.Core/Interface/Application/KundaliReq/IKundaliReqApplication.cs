using System;
using System.Collections.Generic;
using System.Text;
using RRAstro.Core.Domain.KundaliReq;

namespace RRAstro.Core.Interface.Application.KundaliReq
{
    public interface IKundaliReqApplication
    {
        IEnumerable<KundaliRequest> GetAllKundaliReqByUser(string userID);
        KundaliRequest GetKundaliRequestData(long id);
        KundaliRequest SaveKundaliRequest(KundaliRequest kRequest);
        long DeleteKundaliReq(long ID);
    }
}
