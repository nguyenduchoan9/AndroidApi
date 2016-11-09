using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class TestTopicRepository : BaseRepository
    {
        public TestTopicRepository()
        {
            _db = new AndAuEntities();
        }

        public List<TestTopic> GetTopicTestByCourseId(int courseId)
        {
            List<TestTopic> list = _db.TestTopics.Where(x => x.CourseId == courseId).ToList();

            return list;
        }
    }
}