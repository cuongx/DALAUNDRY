using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laundry.Domain.Requests.LoaiHang
{
  public  class SaveLoaiHangRequest
    {
        public int LoaiHangId { get; set; }
        [Required]
        [Display(Name = "Tên Loại Hàng")]
        public string LoaiHangName { get; set; }
    }
}
