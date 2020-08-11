using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Laundry.API.Models;
using Laundry.BAL.Interface;
using Laundry.Domain.Response;
using Laundry.Domain.Request;

namespace Laundry.API.Controllers
{
    [ApiController]
    public class LoaiKhachHangController : Controller
    {
        private readonly ILoaiKhachHangService loaiKhachHangService;

        public LoaiKhachHangController(ILoaiKhachHangService loaiKhachHangService)
        {

            this.loaiKhachHangService = loaiKhachHangService;
        }

        //[HttpGet]
        //[Route("/loaikhachhang/gets")]
        //public async Task<IEnumerable<LoaiKhachHang>> Gets()

        //{
        //    return await loaiKhachHangService.Gets();
        //}

        [HttpGet]
        [Route("/loaikhachhang/get/{id}")]
        public async Task<LoaiKhachHang> Get(int id)
        {

            return await loaiKhachHangService.Get(id);
        }
      
        [HttpPost]
        [Route("/loaikhachhang/save")]
        public async Task<SaveLoaiKhachHangResult> Save(SaveLoaiKhachHangRequest request)
        {
            return await loaiKhachHangService.Save(request);
        }
    
        [HttpDelete]
        [Route("/loaikhachhang/delete/{id}")]
        public async Task<DeleteLoaiKhachHangResult> Delete(int id)
        {
            return await loaiKhachHangService.Delete(id);
        }

    }
}
