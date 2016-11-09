using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class SubjectRepository : BaseRepository
    {
        public SubjectRepository()
        {
            _db = new AndAuEntities();
        }

        public List<Subject> GetSubjectByAccountId(int accountId)
        {
           
            List<Subject> subjects = (from acc in _db.Accounts
                           join cla in _db.Classes on acc.Id equals cla.AccountId
                           join course in _db.Courses on cla.Id equals course.ClassId
                           join sub in _db.Subjects on course.SubjectId equals sub.Id
                           where acc.Id == accountId
                           select sub).ToList();

            return subjects;
        }
    }
}