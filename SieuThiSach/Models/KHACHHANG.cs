//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SieuThiSach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.DONDATHANGs = new HashSet<DONDATHANG>();
        }
    
        public int MaKH { get; set; }
        public string HotenKH { get; set; }
        public string DiachiKH { get; set; }
        public string DienthoaiKH { get; set; }
        public string TenDN { get; set; }
        public string Matkhau { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public bool Gioitinh { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<DONDATHANG> DONDATHANGs { get; set; }
    }
}