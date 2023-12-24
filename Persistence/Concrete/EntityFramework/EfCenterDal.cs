using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Entities.Dtos.Stadiums;
using Entities.Mappings;
using Framework.Persistence.EntityFramework;
using Framework.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework.Contexts;
using System.Linq.Expressions;

namespace Persistence.Concrete.EntityFramework
{
    public class EfCenterDal : EfGenericRepository<Center, MiniStadiumRentDbContext>, ICenterDal
    {
        private readonly MiniStadiumRentDbContext _context;

        public EfCenterDal(MiniStadiumRentDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Center>> GetAllAsync()
        {
            return _context.Centers.Include(c => c.Stadiums).Include(c => c.User).AsQueryable();
        }
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            var year = await _context.Centers.CountAsync(c => c.CreatedDate.Year ==DateTime.Today.Year);
            var month = await _context.Centers.CountAsync(c => c.CreatedDate.Month ==DateTime.Today.Month);
            return new() { ThisMonthCenterCount=month, ThisYearCenterCount=year };
        }
        public async Task<IQueryable<CenterDetailDto>> GetAllWithDetails()
        {
            var result = from c in _context.Centers
                         join u in _context.Users
                         on c.CreatedById equals u.Id
                         join s in _context.Stadiums
                         on c.Id equals s.CenterId into stadiumsGroup
                         select new CenterDetailDto
                         {
                             Id = c.Id,
                             CreatedBy = u.Email,
                             Email = c.Email,
                             Latitude =c.Latitude,
                             Longitude = c.Longitude,
                             Name = c.Name,
                             Number = c.Number,
                             StadiumCount = stadiumsGroup.Count()
                         };
            return result.AsQueryable();
        }
    }
}
