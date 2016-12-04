using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models
{
    public class OrderDao
    {
        BookManagementEntities db;
        public OrderDao()
        {
            db = new BookManagementEntities();
        }
        public bool createOrder(Order order)
        {
            try
            {
                var entity = new Order
                {
                    ID = order.ID,
                    UserName = order.UserName,
                    UserID = order.UserID,
                    StartDate = order.StartDate,
                    EndDate = order.EndDate,
                    StatusID = order.StatusID,
                    Note = order.Note,
                    Address = order.Address,
                    CreatedDate = order.CreatedDate,
                };
                db.Orders.Add(entity);
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