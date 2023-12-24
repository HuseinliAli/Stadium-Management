
using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Framework.Utilities.Results;

namespace Business.Abstract
{
    public interface ICenterService
    {
        Task<IDataResult<IQueryable<CenterDetailDto>>> GetAllAsync();
        Task<IResult> AddAsync(AddOrUpdateCenterDto dto);
        Task<IResult> UpdateAsync(int id, AddOrUpdateCenterDto dto);
        Task<IResult> DeleteByIdAsync(int id);
        public Task<DashboardDto> GetAdminDashboardCounts();
        IDataResult<List<Center>> GetByUserId(int id);
    }
}
