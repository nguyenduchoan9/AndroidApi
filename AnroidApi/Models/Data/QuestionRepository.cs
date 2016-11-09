using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class QuestionRepository : BaseRepository
    {
        public QuestionRepository()
        {
            _db = new AndAuEntities();
        }

        public List<Question> GetQuestionByTopicTest(int topicId)
        {
            List<Question> list = _db.Questions.Where(x => x.TopicId == topicId).ToList();

            return list;
        }
    }
}