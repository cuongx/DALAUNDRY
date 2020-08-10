using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Laundry.API.Models;
using Laundry.BAL.Interface;
using Laundry.Domain.Responses.LoaiHang;
using Laundry.Domain.Requests.LoaiHang;

namespace Laundry.API.Controllers
{
    [ApiController]
    public class LoaiHangController : Controller
    {
        private readonly ILoaiHangService loaiHangService;

        public LoaiHangController(ILoaiHangService loaiHangService)
        {
 
            this.loaiHangService = loaiHangService;
        }

        [HttpGet]
        [Route("/loaihang/gets")]
        public async Task<IEnumerable<LoaiHang>> Gets()

        {
            return await loaiHangService.Gets();
        }
        /// <summary>
        /// get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("/loaihang/get/{id}")]
        public async Task<LoaiHang> Get(int id)
        {

            return await loaiHangService.Get(id);
        }
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/loaihang/save")]
        public async Task<SaveLoaiHangResult> Save(SaveLoaiHangRequest request)
        {
            return await loaiHangService.Save(request);
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/loaihang/delete/{id}")]
        public async Task<DeleteLoaiHangResult> Delete(int id)
        {
            return await loaiHangService.Delete(id);
        }
       
    }
}
