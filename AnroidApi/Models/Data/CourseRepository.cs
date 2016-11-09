using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class CourseRepository : BaseRepository
    {
        public CourseRepository()
        {
            _db=new AndAuEntities();
        }

        public List<Course> GetCourseByAccountId(int accountId)
        {
            List<Course> result = (from acc in _db.Accounts
                join cla in _db.Classes on acc.Id equals cla.AccountId
                join course in _db.Courses on cla.Id equals course.ClassId
                where acc.Id == accountId
                select course).ToList();

            return result;
        }
    }
}