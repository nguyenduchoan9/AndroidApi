using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models
{
    public class BookDAO
    {
        BookManagementEntities _db = null;

        public BookDAO()
        {
            _db = new BookManagementEntities();
        }
        public IEnumerable<Book> ListBook(string searchkey, int page, int pageSize)
        {
            IQueryable<Book> model = _db.Books;
            if (!string.IsNullOrEmpty(searchkey))
            {
                model = model.Where(b => b.Name.Contains(searchkey.Trim()));
            }
            return model.OrderBy(b => b.AddedDate.Day);

        }

        public List<Book> ListBook()
        {
            IQueryable<Book> model = _db.Books;
            return model.OrderBy(b => b.AddedDate.Day).ToList();

        }


        public Book BookDetail(int bookID)
        {
            return _db.Books.SingleOrDefault(m => m.ID == bookID);
        }

        public List<Book> GetByAuthor(int authorID)
        {
            IQueryable<Book> model = _db.Books;
            return model.OrderBy(m => m.Name).Where(m => m.AuthorID == authorID).ToList();
        }

    }
}