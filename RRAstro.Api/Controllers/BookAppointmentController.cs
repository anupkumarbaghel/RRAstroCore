using Microsoft.AspNetCore.Mvc;
using RRAstro.Core.Domain.BookApp;
using RRAstro.Core.Interface.Application.BookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRAstro.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/bookappointment")]
    public class BookAppointmentController : Controller
    {
        private readonly IBookAppointmentApplication _BookAppointmentApplication;
        public BookAppointmentController(IBookAppointmentApplication BookAppointmentApplication)
        {
            _BookAppointmentApplication = BookAppointmentApplication;
        }

        [HttpGet]
        public IActionResult GetAllBookedAppointmentByUser(string userID)
        {
            return Ok(_BookAppointmentApplication.GetAllBookedAppointmentByUser(userID));
        }

        [HttpGet("{id}")]
        public IActionResult GetAllBookedAppointment([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bApp = _BookAppointmentApplication.GetAllBookedAppointment(id);

            if (bApp == null)
            {
                return NotFound();
            }

            return Ok(bApp);
        }

        [HttpPost]
        public IActionResult PostBookAppointment([FromBody] BookAppointment bookApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_BookAppointmentApplication.SaveAppointment(bookApp));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAppointment([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(_BookAppointmentApplication.DeleteAppointment(id));

        }
    }
}
