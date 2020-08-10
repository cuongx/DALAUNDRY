using Laundry.BAL.Interface;
using Laundry.DAL.Interface;
using Laundry.Domain.Requests.LoaiHang;
using Laundry.Domain.Responses.LoaiHang;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.BAL
{
    public class LoaiHangService : ILoaiHangService
    {
        private readonly ILoaiHangRepository loaiHangRepository;

        public LoaiHangService(ILoaiHangRepository loaiHangRepository)
        {
            this.loaiHangRepository = loaiHangRepository;
        }

        public async Task<DeleteLoaiHangResult> Delete(int id)
        {
            return await loaiHangRepository.Delete(id);
        }

        public async Task<LoaiHang> Get(int id)
        {
            return await loaiHangRepository.Get(id);
        }

        public async Task<IEnumerable<LoaiHang>> Gets()
        {
            return await loaiHangRepository.Gets();
        }

        public async Task<SaveLoaiHangResult> Save(SaveLoaiHangRequest request)
        {
            return await loaiHangRepository.Save(request);
        }
    }
}
