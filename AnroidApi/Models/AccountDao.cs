using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models
{
    public class AccountDao
    {
        BookManagementEntities db;
        public AccountDao()
        {
            db = new BookManagementEntities();
        }

        public User Login(String mail, String password)
        {
            bool exist = false;

            var user = db.Users.SingleOrDefault(x => x.Email.Equals(mail) && password.Equals(password));

            exist = user != null ? true : false;

            if (exist)
            {
                return user;
            }
            return null;
        }
        public bool CreateUser(User user)
        {
            try
            {
                var entity = new User
                {
                    Email = user.Email,
                    Name = user.Name,
                    Phone = user.Phone,
                    Pass = user.Pass,
                    DOB = user.DOB,
                    Sex = user.Sex,
                    RoleID = user.RoleID,
                    StatusID = user.StatusID,
                    Address = user.Address,
                    RegDate = System.DateTime.Now,
                    Img_Link = user.Img_Link
                };
                db.Users.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}