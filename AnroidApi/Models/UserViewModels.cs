using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnroidApi.Models
{
    public class UserViewModels
    {

         public int ID { get; set; }
         public string Name { get; set; }
         public string Pass { get; set; }
         public int RoleID { get; set; }
         public System.DateTime DOB { get; set; }
         public Boolean Sex { get; set; }
         public string Img_Link { get; set; }
         public string Address { get; set; }
         public string Phone { get; set; }
         public string Email { get; set; }
         public System.DateTime RegDate { get; set; }
         public int StatusID { get; set; }
        public UserViewModels()
        {

        }
        public UserViewModels(User user)
        {
            ID = user.ID;
            Name = user.Name;
            Pass = user.Pass;
            RoleID = user.RoleID;
            DOB = user.DOB;
            Sex = user.Sex;
            Img_Link = user.Img_Link;
            Address = user.Address;
            Phone = user.Phone;
            Email = user.Email;
            RegDate = user.RegDate;
            StatusID = user.StatusID;
        }
    }
}