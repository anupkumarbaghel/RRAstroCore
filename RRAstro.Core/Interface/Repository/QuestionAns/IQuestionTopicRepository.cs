using RRAstro.Core.Domain.QuestionAns;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRAstro.Core.Interface.Repository.QuestionAns
{
    public interface IQuestionTopicRepository
    {
        IEnumerable<QuestionTopic> GetAllQuestionTopicsOfUser(string userID);
        QuestionTopic GetQuestionTopic(long id);
        QuestionTopic CreateEditTopic(QuestionTopic topic);
        long DeleteTopic(long ID);
    }
}
