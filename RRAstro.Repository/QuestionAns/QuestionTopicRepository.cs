using RRAstro.Core.Interface.Repository.QuestionAns;
using System;
using System.Collections.Generic;
using System.Text;
using RRAstro.Core.Domain.QuestionAns;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RRAstro.Repository.QuestionAns
{
    public class QuestionTopicRepository : IQuestionTopicRepository
    {

        RRAstroDBContext _context;
        public QuestionTopicRepository(RRAstroDBContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public QuestionTopic CreateEditTopic(QuestionTopic topic)
        {
            if (topic.ID > 0)
            {
                _context.Update(topic);
            }
            else
            {
                _context.Add(topic);
            }
           
            _context.SaveChanges();
            return topic;
        }

        public long DeleteTopic(long ID)
        {
            QuestionTopic topic = _context.QuestionTopics.FirstOrDefault(e => e.ID == ID);
            if (topic == null) return -1;

            _context.QuestionTopics.Remove(topic);
            _context.SaveChanges();
            return topic.ID;
        }

        public IEnumerable<QuestionTopic> GetAllQuestionTopicsOfUser(string userID)
        {
            return _context.QuestionTopics
               .Where(e => e.UserID == userID).ToList();
        }

        public QuestionTopic GetQuestionTopic(long id)
        {
            return _context.QuestionTopics.Include(e => e.QuestionList)
               .ThenInclude(f => f.ReplyList)
               .FirstOrDefault(e => e.ID == id);
        }
    }
}
