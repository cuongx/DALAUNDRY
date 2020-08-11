using Laundry.Domain.Request;
using Laundry.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Laundry.BAL.Interface
{
    public interface ILoaiKhachHangService
    {
        Task<IEnumerable<LoaiKhachHang>> Gets();
        Task<LoaiKhachHang> Get(int id);
        Task<SaveLoaiKhachHangResult> Save(SaveLoaiKhachHangRequest request);
        Task<DeleteLoaiKhachHangResult> Delete(int id);
    }
}
