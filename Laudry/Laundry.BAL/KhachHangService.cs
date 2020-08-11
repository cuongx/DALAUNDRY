using Laundry.BAL.Interface;
using Laundry.DAL.Interface;
using Laundry.Domain.Request;
using Laundry.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Laundry.BAL
{
    public class LoaiKhachHangService : ILoaiKhachHangService
    {
        private readonly ILoaiKhachHangRepository loaiKhachHangRepository;

        public LoaiKhachHangService(ILoaiKhachHangRepository loaiKhachHangRepository)
        {
            this.loaiKhachHangRepository = loaiKhachHangRepository;
        }

        public async Task<DeleteLoaiKhachHangResult> Delete(int id)
        {
            return await loaiKhachHangRepository.Delete(id);
        }

        public async Task<LoaiKhachHang> Get(int id)
        {
            return await loaiKhachHangRepository.Get(id);
        }

        public async Task<IEnumerable<LoaiKhachHang>> Gets()
        {
            return await loaiKhachHangRepository.Gets();
        }

        public async Task<SaveLoaiKhachHangResult> Save(SaveLoaiKhachHangRequest request)
        {
            return await loaiKhachHangRepository.Save(request);
        }

     
    }
}
