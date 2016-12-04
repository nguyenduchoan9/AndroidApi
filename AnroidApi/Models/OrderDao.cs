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
        public bool createOrder(String username, int userId, String note, String address, int bookId, double price)
        {
            try
            {
                var entity = new Order
                {
                    UserName = username,
                    UserID = userId,
                    StartDate = System.DateTime.Now,
                    EndDate = System.DateTime.Now,
                    StatusID = 1,
                    Note = note,
                    Address = address,
                    CreatedDate = System.DateTime.Now,
                };
                db.Orders.Add(entity);
                int ac = db.SaveChanges();
                if (ac > 0)
                {
                    OrderDetail od = new OrderDetail
                    {
                        BookID = bookId,
                        Quantity = 1,
                        Price = price
                    };
                    db.OrderDetails.Add(od);
                    int rs = db.SaveChanges();
                    if (rs > 0)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        //public List<Order> ViewOrder(int userID)
        //{

        //}

    }
}