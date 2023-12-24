using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Entities.Dtos.Stadiums;
using Entities.Mappings;
using Framework.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework.Contexts;
using System.Linq;

namespace Persistence.Concrete.EntityFramework
{
    public class EfStadiumDal : EfGenericRepository<Stadium, MiniStadiumRentDbContext>, IStadiumDal
    {
        private MiniStadiumRentDbContext _context;

        public EfStadiumDal(MiniStadiumRentDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Stadium>> GetAllAsync()
        {
            return await _context.Stadiums.ToListAsync();
        }
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            var year = await _context.Stadiums.CountAsync(c => c.CreatedDate.Year ==DateTime.Today.Year);
            var month = await _context.Stadiums.CountAsync(c => c.CreatedDate.Month ==DateTime.Today.Month);
            return new() { ThisMonthStadiumCount=month, ThisYearStadiumCount=year };
        }
        public async Task<IQueryable<StadiumWithCenterDto>> GetAllWithDetailsAsync()
        {
            var result = from s in _context.Stadiums
                         join c in _context.Centers
                         on s.CenterId equals c.Id
                         
                         select new StadiumWithCenterDto
                         {
                             StadiumId = s.Id,
                             StadiumPictureUrl=s.PictureUrl,
                             StadiumHallName=s.HallName,
                             StadiumPriceMorning=s.PriceMorning,
                             StadiumPriceAfternoon=s.PriceAfternoon,
                             StadiumPriceEvening=s.PriceAfternoon,
                             StadiumOpenTime=s.OpenTime,
                             StadiumCloseTime=s.CloseTime,
                             CenterId=c.Id,
                             CenterAddress=c.Address,
                             CenterEmail=c.Email,
                             CenterLatitude=c.Latitude,
                             CenterLongitude=c.Longitude,
                             CenterName=c.Name,
                             CenterNumber=c.Number
                         };

            return result.AsQueryable();
        }
    }
}
