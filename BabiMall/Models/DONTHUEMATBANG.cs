//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BabiMall.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONTHUEMATBANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONTHUEMATBANG()
        {
            this.CTTHUEMATBANGs = new HashSet<CTTHUEMATBANG>();
        }
    
        public int Somatbang { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<System.DateTime> Ngaythue { get; set; }
        public Nullable<decimal> Trigia { get; set; }
        public string Tennguoithue { get; set; }
        public Nullable<bool> HTThanhtoan { get; set; }
        public string Dientichthue { get; set; }
        public string Dienthoai { get; set; }
        public string Thoihanthue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTTHUEMATBANG> CTTHUEMATBANGs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
