using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models
{
    public class OrderViewModels
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int StatusID { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
       public System.DateTime CreatedDate { get; set; }
        public OrderViewModels()
        {

        }
        public OrderViewModels(Order order)
        {
            ID = order.ID;
            UserName = order.UserName;
            UserID = order.UserID;
            StartDate = order.StartDate;
            EndDate = order.EndDate;
            StatusID = order.StatusID;
            Note = order.Note;
            Address = order.Address;
            CreatedDate = order.CreatedDate;
        }
    }
}