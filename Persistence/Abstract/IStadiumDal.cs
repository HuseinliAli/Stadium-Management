using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Entities.Dtos.Stadiums;
using Framework.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Abstract
{
    public interface IStadiumDal : IGenericRepository<Stadium>
    {
        Task<IQueryable<StadiumWithCenterDto>> GetAllWithDetailsAsync();
        Task<ICollection<Stadium>> GetAllAsync();
        public Task<DashboardDto> GetAdminDashboardCounts();
    }
}
