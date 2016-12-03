//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnroidApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public int RoleID { get; set; }
        public System.DateTime DOB { get; set; }
        public bool Sex { get; set; }
        public string Img_Link { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public System.DateTime RegDate { get; set; }
        public int StatusID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Role Role { get; set; }
        public virtual UserStatu UserStatu { get; set; }
    }
}
