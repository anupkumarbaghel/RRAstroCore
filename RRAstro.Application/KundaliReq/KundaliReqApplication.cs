using RRAstro.Core.Domain.KundaliReq;
using RRAstro.Core.Interface.Application.KundaliReq;
using RRAstro.Core.Interface.Repository.KundaliReq;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Application.KundaliReq
{
    public class KundaliReqApplication : IKundaliReqApplication
    {
        IKundaliReqRepository _kundaliReqService;
        public KundaliReqApplication(IKundaliReqRepository kundaliReqService)
        {
            _kundaliReqService = kundaliReqService;
        }

        public IEnumerable<KundaliRequest> GetAllKundaliReqByUser(string userID)
        {
            return _kundaliReqService.GetAllKundaliReqByUser(userID);
        }
        public KundaliRequest GetKundaliRequestData(long id)
        {
            return _kundaliReqService.GetKundaliRequestData(id);
        }
        public KundaliRequest SaveKundaliRequest(KundaliRequest kRequest)
        {
            return _kundaliReqService.SaveKundaliRequest(kRequest);
        }
        public long DeleteKundaliReq(long ID)
        {
            return _kundaliReqService.DeleteKundaliReq(ID);
        }
    }
}
