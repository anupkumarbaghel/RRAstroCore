using RRAstro.Core.Domain.QuestionAns;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Application.QuestionAns
{
    public interface IQuestionTopicApplication
    {
        IEnumerable<QuestionTopic> GetAllQuestionTopicsOfUser(string userID);
        QuestionTopic GetQuestionTopic(long id);
        QuestionTopic CreateEditQuestionTopic(QuestionTopic topic);
        long DeleteQuestionTopic(long ID);
    }
}
