using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Rents;
using Framework.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Abstract
{
    public interface IRentDal:IGenericRepository<Rent>
    {
        IQueryable<Rent> GetAll();
        public Task<DashboardDto> GetAdminDashboardCounts();
        public Task<List<GetDetailRentDto>> GetDetailRentDtos();
    }
}
