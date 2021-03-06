//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sequence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sequence()
        {
            this.Shots = new HashSet<Shot>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Profile Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shot> Shots { get; set; }
        public virtual Member Member { get; set; }
        public virtual Price Price { get; set; }
        public virtual Sequence NextSequence { get; set; }
        public virtual Sequence PreviousSequence { get; set; }
    }
}
