using Microsoft.AspNetCore.Mvc;
using RRAstro.Core.Domain.KundaliReq;
using RRAstro.Core.Interface.Application.KundaliReq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRAstro.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/kundalireq")]
    public class KundaliReqController: Controller
    {
        private readonly IKundaliReqApplication _kundaliReqApplication;
        public KundaliReqController(IKundaliReqApplication kundaliReqApplication)
        {
            _kundaliReqApplication = kundaliReqApplication;
        }

        [HttpGet]
        public IActionResult GetAllKundaliReqByUser(string userID)
        {
            return Ok(_kundaliReqApplication.GetAllKundaliReqByUser(userID));
        }

        [HttpGet("{id}")]
        public IActionResult GetKundaliRequestData([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kReq = _kundaliReqApplication.GetKundaliRequestData(id);

            if (kReq == null)
            {
                return NotFound();
            }

            return Ok(kReq);
        }

        [HttpPost]
        public IActionResult PostKundaliRequest([FromBody] KundaliRequest kReq)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_kundaliReqApplication.SaveKundaliRequest(kReq));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteKundaliReq([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(_kundaliReqApplication.DeleteKundaliReq(id));

        }

    }
}
