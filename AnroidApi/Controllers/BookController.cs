using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AnroidApi.Models;

namespace AnroidApi.Controllers
{
    [RoutePrefix("api/v1/Book")]
    public class BookController : ApiController
    {

        [HttpGet]
        [Route("GetBook")]
        public IHttpActionResult GetBook(String mail, String password)
        {
            BookDAO dao = new BookDAO();
            var books = dao.ListBook().ToList();
            return Json(new
            {
                books
            });
        }

        [HttpGet]
        [Route("GetBookDetail")]
        public IHttpActionResult GetBookDetail(int bookId)
        {
            BookDAO dao = new BookDAO();
            var book = dao.BookDetail(bookId);
            return Json(new
            {
                book
            });
        }

        [HttpGet]
        [Route("GetBookByAuthor")]
        public IHttpActionResult GetBookByAuthor(int authorId)
        {
            BookDAO dao = new BookDAO();
            var books = dao.GetByAuthor(authorId).ToList();
            return Json(new
            {
                books
            });
        }
    }
}
