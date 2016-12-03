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
                    user
                });
            }
            UserViewModels viewmodel = new UserViewModels(user);
            return Json(new
            {
                viewmodel
            });
        }
    }

    //http://stackoverflow.com/questions/20901419/how-to-call-stored-procedure-in-entity-framework-6-code-first
    //https://msdn.microsoft.com/en-us/library/ms345415.aspx
}
