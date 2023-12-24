using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Rents;
using Entities.Dtos.Stadiums;
using Framework.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentService
    {
        IDataResult<IQueryable<Rent>> GetAll();
        Task<IResult> AddAsync(AddOrUpdateRentDto dto);
        public Task<DashboardDto> GetAdminDashboardCounts();
        Task<IResult> DeleteByIdAsync(int id);
        public Task<IDataResult<AddOrUpdateRentDto>> CheckoutForUser(AddOrUpdateRentDto dto);
        public Task<List<GetDetailRentDto>> GetDetailRentDtos();
    }
}
