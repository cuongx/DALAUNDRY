using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Laundry.Domain.Response
{
   public class LoaiKhachHang
    {
        public int LoaiKhachHangId { get; set; }
        [Required]
        [Display(Name = "Tên Loại Khách Hàng")]
        public string LoaiKhachHangName { get; set; }
        
    }
}
