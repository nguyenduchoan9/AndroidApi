using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models
{
    public class BookViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img_Link { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> Rate { get; set; }
        public double Price { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public int PublisherID { get; set; }
        public System.DateTime AddedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public BookViewModel()
        {

        }
        public BookViewModel(Book book)
        {
            ID = book.ID;
            Name = book.Name;
            Description = book.Description;
            Img_Link = book.Img_Link;
            StatusID = book.StatusID;
            Rate = book.Rate;
            Price = book.Price;
            AuthorID = AuthorID;
            GenreID = book.GenreID;
            PublisherID = book.PublisherID;
            AddedDate = book.AddedDate;
            ModifiedDate = book.ModifiedDate;
        }
    }
}