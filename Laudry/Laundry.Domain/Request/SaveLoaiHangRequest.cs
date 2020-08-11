using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laundry.Domain.Request
{
     public class SaveLoaiKhachHangRequest
    {
        public int LoaiKhachHangId { get; set; }
        [Required]
        [Display(Name = "Tên Loại Khách Hàng")]
        public string LoaiKhachHangName { get; set; }
    }
}
