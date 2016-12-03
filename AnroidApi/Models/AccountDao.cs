using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models
{
    public class AccountDao
    {
        BookManagementEntities entity;
        public AccountDao()
        {
            entity = new BookManagementEntities();
        }

        public bool Login(String mail, String password)
        {
            bool exist = false;

            var user = entity.Users.SingleOrDefault(x => x.Email.Equals(mail) && password.Equals(password));

            exist = user != null ? true : false;

            return exist;
        }
    }
}