using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Rents;
using Framework.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concrete.EntityFramework
{
    public class EfRentDal : EfGenericRepository<Rent, MiniStadiumRentDbContext>, IRentDal
    {
        private readonly MiniStadiumRentDbContext _context;

        public EfRentDal(MiniStadiumRentDbContext context)
        {
            _context = context;
        }

        public IQueryable<Rent> GetAll()
        {
            return _context.Rents.Include(r => r.Stadium).Include(c => c.User).AsQueryable();
        }
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            var year = await _context.Rents.CountAsync(c => c.CreatedDate.Year ==DateTime.Today.Year);
            var month = await _context.Rents.CountAsync(c => c.CreatedDate.Month ==DateTime.Today.Month);
            return new() { ThisMonthRentCount=month, ThisYearRentCount=year };
        }

        public  async Task<List<GetDetailRentDto>> GetDetailRentDtos()
        {
            var result = from r in _context.Rents
                         join u in _context.Users
                         on r.UserId equals u.Id
                         join s in _context.Stadiums
                         on r.StadiumId equals s.Id
                         select new GetDetailRentDto()
                         {
                             Id= r.Id,
                             StadiumName=s.HallName,
                             Price=r.TotalPrice,
                             Start=r.Start,
                             Finish=r.Finish,
                             UserEmail=u.Email,
                             UserId=u.Id,
                             StadiumId=s.Id,
                             CreatedAt=r.CreatedDate
                         };
            return await result.ToListAsync();
        }
    }
}
