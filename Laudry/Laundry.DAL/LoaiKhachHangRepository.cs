using Dapper;
using Laundry.DAL.Interface;
using Laundry.Domain.Request;
using Laundry.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Laundry.DAL
{
    public class LoaiKhachHangRepository : BaseRepository, ILoaiKhachHangRepository
    {
        public async Task<DeleteLoaiKhachHangResult> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add(@"LoaiKhachHangId", id);
            return await SqlMapper.QueryFirstAsync<DeleteLoaiKhachHangResult>(con, param: parameters, sql: "sp_DeleteLoaiKhachHang", commandType: CommandType.StoredProcedure);
        }

        public async Task<LoaiKhachHang> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add(@"LoaiKhachHangId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<LoaiKhachHang>(con, param: parameters, sql: "sp_GetLoaiKhachHang", commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<LoaiKhachHang>> Gets()
        {
            return await SqlMapper.QueryAsync<LoaiKhachHang>(cnn: con,
                                                sql: "sp_GetLoaiKhachHangs",
                                                commandType: CommandType.StoredProcedure);

        }

        public async Task<SaveLoaiKhachHangResult> Save(SaveLoaiKhachHangRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(@"LoaiKhachHangId", request.LoaiKhachHangId);
                parameters.Add(@"LoaiKhachHangName", request.LoaiKhachHangName);
                return await SqlMapper.QueryFirstOrDefaultAsync<SaveLoaiKhachHangResult>(
                                         cnn: con, param: parameters,
                                         sql: "sp_SaveLoaiKhachHang",
                                         commandType: CommandType.StoredProcedure);
            }
            catch (Exception )
            {
                return new SaveLoaiKhachHangResult()
                {
                    LoaiKhachHangId = 0,
                    Message = "Error, please try again"

                };
            }
        }

        
    }
}

