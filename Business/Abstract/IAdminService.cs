using Entities.Dtos.Admin;
using Framework.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        public IDataResult<DashboardDto> GetDashboard();
    }
}
