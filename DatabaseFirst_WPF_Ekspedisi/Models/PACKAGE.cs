//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst_WPF_Ekspedisi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PACKAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACKAGE()
        {
            this.SHIPPINGS = new HashSet<SHIPPING>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public decimal PRICE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPPING> SHIPPINGS { get; set; }
    }
}
