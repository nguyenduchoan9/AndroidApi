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
        public IHttpActionResult GetBook()
        {
            BookDAO dao = new BookDAO();
            var books = dao.ListBook().ToList();

            List<BookViewModel> viewModels = new List<BookViewModel>();
            foreach(Book book in books){
                BookViewModel viewmodel = new BookViewModel(book);
                viewModels.Add(viewmodel);
            }
            return Json(new
            {
               results=viewModels
            });
        }

        [HttpGet]
        [Route("GetBookDetail")]
        public IHttpActionResult GetBookDetail(int bookId)
        {
            BookDAO dao = new BookDAO();
            var book = dao.BookDetail(bookId);
            BookViewModel viewmodel = new BookViewModel(book);
            return Json(new
            {
                results = viewmodel
            });
        }

        [HttpGet]
        [Route("GetBookByAuthor")]
        public IHttpActionResult GetBookByAuthor(int authorId)
        {
            BookDAO dao = new BookDAO();
            var books = dao.GetByAuthor(authorId).ToList();
            List<BookViewModel> viewModels = new List<BookViewModel>();
            foreach (Book book in books)
            {
                BookViewModel viewmodel = new BookViewModel(book);
                viewModels.Add(viewmodel);
            }
            return Json(new
            {
                results = viewModels
            });
        }
    }
}
