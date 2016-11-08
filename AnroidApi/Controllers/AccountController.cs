using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using AnroidApi.Models;
using AnroidApi.Models.Data;
using AnroidApi.Providers;
using AnroidApi.Results;

namespace AnroidApi.Controllers
{
    [System.Web.Http.RoutePrefix("api/v1/Account")]
    public class AccountController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("Login")]
        public IHttpActionResult Login(string username, string password)
        {
            string msg = "";

            AccountRepository accountRepository = new AccountRepository();
            Account account = accountRepository.Login(username, password);

            if (null == account)
            {
                msg = "Invalid username or password";
                return Json(new
                {
                    exist = false,
                    message = msg,
                    accountModel = "null"
                });

            }
            return Json(new
            {
                exist = true,
                message = msg,
                accountModel = new
                {
                    Id = account.Id,
                    Username = account.Username,
                    Email = account.Email,
                    Role = account.Role
                }
            });
        }
    }
}
