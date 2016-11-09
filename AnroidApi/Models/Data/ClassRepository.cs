using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class ClassRepository : BaseRepository
    {

        public ClassRepository()
        {
            _db = new AndAuEntities();
        }

        public List<Class> GetClassByAccountId(int accountId)
        {
            List<Class> list = _db.Classes.Where(x => x.AccountId == accountId).ToList();

            return list;
        }
    }
}