using Dapper;
using Laundry.DAL.Interface;
using Laundry.Domain.Requests.LoaiHang;
using Laundry.Domain.Responses.LoaiHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.DAL
{
    public class LoaiHangRepository : BaseRepository, ILoaiHangRepository
    {
        public async Task<DeleteLoaiHangResult> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add(@"LoaiHangId", id);
            return await SqlMapper.QueryFirstAsync<DeleteLoaiHangResult>(con, param: parameters, sql: "sp_DeleteLoaiHang", commandType: CommandType.StoredProcedure);
        }

        public async Task<LoaiHang> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add(@"LoaiHangId", id);
            return await SqlMapper.QueryFirstAsync<LoaiHang>(con, param:parameters,sql:"sp_GetLoaiHang", commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<LoaiHang>> Gets()
        {
            return await SqlMapper.QueryAsync<LoaiHang>(cnn: con,
                                                sql: "sp_GetLoaiHangs",
                                                commandType: CommandType.StoredProcedure);

        }

        public async Task<SaveLoaiHangResult> Save(SaveLoaiHangRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(@"LoaiHangId", request.LoaiHangId);
                parameters.Add(@"LoaiHangName", request.LoaiHangName);
                return await SqlMapper.QueryFirstOrDefaultAsync<SaveLoaiHangResult>(
                                         cnn: con, param: parameters,
                                         sql: "sp_SaveLoaiHang",
                                         commandType: CommandType.StoredProcedure);
            }
            catch (Exception e)
            {
                return new SaveLoaiHangResult()
                {
                    LoaiHangId = 0,
                    Message = "Something went wrong, please try again"

                };
            }
        }
    }
}
