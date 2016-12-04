using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AnroidApi.Models;

namespace AnroidApi.Controllers
{
    [RoutePrefix("api/v1/Order")]
    public class OrderController : ApiController
    {
        [HttpGet]
        [Route("Order")]
        public IHttpActionResult getAccount(String username, String userId, String note, String address, String bookId, String price)
        {
            OrderDao dao = new OrderDao();
            var userID = Int32.Parse(userId);
            var bookID = Int32.Parse(bookId);
            var priceD = Double.Parse(price);
            var user = dao.createOrder(username, userID,note,address, bookID, priceD);
            if (user == false)
            {
                return Json(new
                {
                    status = false
                });
            }
            return Json(new
            {
                status = true
            });
        }
    }
}
