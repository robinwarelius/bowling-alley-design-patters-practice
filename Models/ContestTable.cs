//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BengansBowlingApplikation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContestTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContestTable()
        {
            this.BookTable = new HashSet<BookTable>();
        }
    
        public int ContestNumber { get; set; }
        public string ContestDate { get; set; }
        public string ContestTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookTable> BookTable { get; set; }
    }
}
