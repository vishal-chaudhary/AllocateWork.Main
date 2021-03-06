//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Allocat.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShippingDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShippingDetail()
        {
            this.ProductEntity = new HashSet<ProductEntity>();
        }
    
        public int ShippingDetailId { get; set; }
        public string ShippingMethod { get; set; }
        public Nullable<int> HospitalAddressId { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
    
        public virtual HospitalAddress HospitalAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductEntity> ProductEntity { get; set; }
    }
}
