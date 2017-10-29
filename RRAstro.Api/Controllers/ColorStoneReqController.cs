using Microsoft.AspNetCore.Mvc;
using RRAstro.Core.Domain.GetColorStone;
using RRAstro.Core.Interface.Application.GetColorStone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRAstro.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/colorstonereq")]
    public class ColorStoneReqController : Controller
    {
        private readonly IColorStoneReqApplication _ColorStoneReqApplication;
        public ColorStoneReqController(IColorStoneReqApplication ColorStoneReqApplication)
        {
            _ColorStoneReqApplication = ColorStoneReqApplication;
        }

        [HttpGet]
        public IActionResult GetAllColorStoneReqByUser(string userID)
        {
            return Ok(_ColorStoneReqApplication.GetAllColorStoneReqByUser(userID));
        }

        [HttpGet("{id}")]
        public IActionResult GetColorStoneRequestData([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var colorStoneReq = _ColorStoneReqApplication.GetColorStoneReqData(id);

            if (colorStoneReq == null)
            {
                return NotFound();
            }

            return Ok(colorStoneReq);
        }

        [HttpPost]
        public IActionResult PostColorStoneRequest([FromBody] ColorStoneReq colorStoneReq)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_ColorStoneReqApplication.SaveColorStoneReq(colorStoneReq));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteColorStoneReq([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(_ColorStoneReqApplication.DeleteColorStoneReq(id));

        }

    }
}

