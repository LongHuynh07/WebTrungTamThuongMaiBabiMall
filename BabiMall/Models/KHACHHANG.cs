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
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.DONTHUEMATBANGs = new HashSet<DONTHUEMATBANG>();
        }
    
        public int MaKH { get; set; }
        public string HoTenKH { get; set; }
        public string DienthoaiKH { get; set; }
        public string TenDN { get; set; }
        public string Matkhau { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public Nullable<bool> Daduyet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONTHUEMATBANG> DONTHUEMATBANGs { get; set; }
    }
}
