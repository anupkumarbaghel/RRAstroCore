using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RRAstro.Core.Interface.Application;
using RRAstro.Core.Domain.QuestionAns;
using RRAstro.Core.Interface.Application.QuestionAns;

namespace RRAstro.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/questiontopic")]
    public class QuestionTopicController : Controller
    {
        private readonly IQuestionTopicApplication _topicApplication;
        public QuestionTopicController(IQuestionTopicApplication topicApplication)
        {
            _topicApplication = topicApplication;
        }

        [HttpGet]
        public IActionResult GetAllQuestionTopic(string userID)
        {
            return Ok(_topicApplication.GetAllQuestionTopicsOfUser(userID));
        }

        [HttpGet("{id}")]
        public IActionResult GetQuestionTopic([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var topic = _topicApplication.GetQuestionTopic(id);

            if (topic == null)
            {
                return NotFound();
            }

            return Ok(topic);
        }

        [HttpPost]
        public IActionResult PostQuestionTopic([FromBody] QuestionTopic topic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_topicApplication.CreateEditQuestionTopic(topic));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteQuestionTopic([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(_topicApplication.DeleteQuestionTopic(id));

        }

    }
}
