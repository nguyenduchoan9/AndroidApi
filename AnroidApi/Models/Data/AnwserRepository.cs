using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class AnwserRepository : BaseRepository
    {
        public AnwserRepository()
        {
            _db = new AndAuEntities();
        }

        public List<Anwser> GetAnswerByQuestionId(int questionId)
        {
            List<Anwser> anwsers = _db.Anwsers.Where(x => x.QuestionId == questionId).ToList();
            return anwsers;
        }
    }
}