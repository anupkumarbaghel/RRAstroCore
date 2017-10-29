using RRAstro.Core.Domain.KundaliReq;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Repository.KundaliReq
{
    public interface IKundaliReqRepository
    {
        IEnumerable<KundaliRequest> GetAllKundaliReqByUser(string userID);
        KundaliRequest GetKundaliRequestData(long id);
        KundaliRequest SaveKundaliRequest(KundaliRequest kRequest);
        long DeleteKundaliReq(long ID);

    }
}
