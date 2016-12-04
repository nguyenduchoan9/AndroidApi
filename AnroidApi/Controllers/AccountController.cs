using System;
using System.Collections.Generic;

using System.Web.Http;
using AnroidApi.Models;

namespace AnroidApi.Controllers
{
    [RoutePrefix("api/v1/Account")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("Loginaa")]
        public IHttpActionResult Login(string username, string password)
        {
           
            //            Account account = accountRepository.Login(username, password);
            //
            //            if (null == account)
            //            {
            //                msg = "Invalid username or password";
            //                return Json(new
            //                {
            //                    exist = false,
            //                    message = msg,
            //                    accountModel = "null"
            //                });
            //
            //            }
            //            return Json(new
            //            {
            //                exist = true,
            //                message = msg,
            //                accountModel = new
            //                {
            //                    Id = account.Id,
            //                    Username = account.Username,
            //                    Email = account.Email,
            //                    Role = account.Role
            //                }
            //            });
            return Json(new
            {
                exist = true,
                message = "success"
            });
        }

        [HttpGet]
        [Route("Login")]
        public IHttpActionResult getAccount(String mail, String password)
        {
            AccountDao dao = new AccountDao();
            var user = dao.Login(mail, password);
            if(user == null)
            {
                return Json(new
                {
                    result = new UserViewModels()
            });
            }
            UserViewModels viewmodel = new UserViewModels(user);
            return Json(new
            {
                result = viewmodel
            });
        }

        [HttpGet]
        [Route("Register")]
        public IHttpActionResult registerAccount(String name, String password, String email, String phone, String sex, String address)
        {
            User user = new User()
            {
                Name = name,
                Email = email,
                Phone = phone,
                Sex = sex.Equals("1") ? true : false,
                Address = address,
                DOB = System.DateTime.Now,
                RoleID = 2,
                Img_Link = "",
                StatusID = 1,
                RegDate  = System.DateTime.Now
            };
            AccountDao dao = new AccountDao();
            var userEntity= dao.CreateUser(user);
            if (userEntity == null)
            {
                return Json(new
                {
                    result = new UserViewModels()
                });
            }
            UserViewModels viewmodel = new UserViewModels(user);
            return Json(new
            {
                result = viewmodel
            });
        }
    }

    //http://stackoverflow.com/questions/20901419/how-to-call-stored-procedure-in-entity-framework-6-code-first
    //https://msdn.microsoft.com/en-us/library/ms345415.aspx
}
