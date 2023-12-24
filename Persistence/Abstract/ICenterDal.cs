using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Framework.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Abstract
{
    public interface ICenterDal : IGenericRepository<Center>
    {
        Task<IQueryable<Center>> GetAllAsync();
        Task<IQueryable<CenterDetailDto>> GetAllWithDetails();
        public Task<DashboardDto> GetAdminDashboardCounts();
    }
}
