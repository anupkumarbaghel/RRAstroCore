using RRAstro.Core.Domain.GetColorStone;
using RRAstro.Core.Interface.Application.GetColorStone;
using RRAstro.Core.Interface.Repository.GetColorStone;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Application.GetColorStone
{
    public class ColorStoneReqApplication : IColorStoneReqApplication
    {
        IColorStoneReqRepository _colorStoneReqService;
        public ColorStoneReqApplication(IColorStoneReqRepository colorStoneReqService)
        {
            _colorStoneReqService = colorStoneReqService;
        }

        public IEnumerable<ColorStoneReq> GetAllColorStoneReqByUser(string userID)
        {
            return _colorStoneReqService.GetAllColorStoneReqByUser(userID);
        }
        public ColorStoneReq GetColorStoneReqData(long id)
        {
            return _colorStoneReqService.GetColorStoneReqData(id);
        }
        public ColorStoneReq SaveColorStoneReq(ColorStoneReq colorStoneRequest)
        {
            return _colorStoneReqService.SaveColorStoneReq(colorStoneRequest);
        }
        public long DeleteColorStoneReq(long ID)
        {
            return _colorStoneReqService.DeleteColorStoneReq(ID);
        }
    }
}
