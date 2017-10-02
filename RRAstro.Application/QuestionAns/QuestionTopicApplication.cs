using RRAstro.Core.Interface.Application;
using System;
using System.Collections.Generic;
using System.Text;
using RRAstro.Core.Domain.QuestionAns;
using RRAstro.Core.Interface.Repository.QuestionAns;
using RRAstro.Core.Interface.Application.QuestionAns;

namespace RRAstro.Application.QuestionAns
{
    public class QuestionTopicApplication : IQuestionTopicApplication
    {
        IQuestionTopicRepository _topicService;
        public QuestionTopicApplication(IQuestionTopicRepository topicService)
        {
            _topicService = topicService;
        }

        public QuestionTopic CreateEditQuestionTopic(QuestionTopic topic)
        {
            return _topicService.CreateEditTopic(topic);
        }

        public long DeleteQuestionTopic(long ID)
        {
            return _topicService.DeleteTopic(ID);
        }

        public IEnumerable<QuestionTopic> GetAllQuestionTopicsOfUser(string userID)
        {
            return _topicService.GetAllQuestionTopicsOfUser(userID);
        }

        public QuestionTopic GetQuestionTopic(long id)
        {
            return _topicService.GetQuestionTopic(id);
        }
    }
}
