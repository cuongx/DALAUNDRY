using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laundry.Domain.Responses.LoaiHang
{
  public  class LoaiHang
    {
       public int LoaiHangId { get; set; }
        [Required]
        [Display(Name ="Tên Loại Hàng")]
        public string LoaiHangName { get; set; }
    }
}
