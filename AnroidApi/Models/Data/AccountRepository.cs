using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class AccountRepository : BaseRepository
    { 

        public AccountRepository()
        {
            _db = new AndAuEntities();
        }

        public  Account Login(string username, string password)
        {
            Account account =  _db.Accounts.SingleOrDefault(x => x.Username == username && x.Password == password);
            

            return account;
        }
    }
}