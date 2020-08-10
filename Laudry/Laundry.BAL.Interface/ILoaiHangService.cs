using Laundry.Domain.Requests.LoaiHang;
using Laundry.Domain.Responses.LoaiHang;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.BAL.Interface
{
   public interface ILoaiHangService
    {
        Task<IEnumerable<LoaiHang>> Gets();
        Task<LoaiHang> Get(int id);
        Task<SaveLoaiHangResult> Save(SaveLoaiHangRequest request);
        Task<DeleteLoaiHangResult> Delete(int id);

    }
}
