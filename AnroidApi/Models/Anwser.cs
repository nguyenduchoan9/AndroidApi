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
    
    public partial class Anwser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anwser()
        {
            this.PostAwards = new HashSet<PostAward>();
        }
    
        public int Id { get; set; }
        public string AnswerPara { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Question Question { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostAward> PostAwards { get; set; }
    }
}