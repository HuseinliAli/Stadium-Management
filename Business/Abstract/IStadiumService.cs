
using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Stadiums;
using Framework.Utilities.Results;

namespace Business.Abstract
{
    public interface IStadiumService
    {
        Task<IDataResult<ICollection<Stadium>>> GetAllAsync();
        Task<IDataResult<IQueryable<StadiumWithCenterDto>>> GetAllWithDetailsAsync();
        Task<IDataResult<ICollection<Stadium>>> GetByUserId(int id);
        Task<IResult> AddAsync(AddOrUpdateStadiumDto dto);
        Task<IResult> UpdateAsync(int id,AddOrUpdateStadiumDto dto);
        Task<IResult> DeleteByIdAsync(int id);
        public Task<DashboardDto> GetAdminDashboardCounts();
    }
}
