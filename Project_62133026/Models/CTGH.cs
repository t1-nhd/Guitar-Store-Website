//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_62133026.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTGH
    {
        public string maGH { get; set; }
        public string maSP { get; set; }
        public byte soLuong { get; set; }
        public bool daThanhToan { get; set; }
    
        public virtual GioHang GioHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
