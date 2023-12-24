using Business.Abstract;
using Business.Aspects.Autofac;
using Entities.Dtos.Admin;
using Framework.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminService : IAdminService
    {
        private IUserService _userService;
        private ICenterService _centerService;
        private IRentService _rentService;
        private IStadiumService _stadiumService;
        public AdminService(IUserService userService, ICenterService centerService, IRentService rentService, IStadiumService stadiumService)
        {
            _centerService = centerService;
            _userService = userService;
            _rentService = rentService;
            _stadiumService=stadiumService;
        }
        [SecuredOperation("admin")]
        public IDataResult<DashboardDto> GetDashboard()
        {
            return new SuccessDataResult<DashboardDto>(new DashboardDto()
            {
                ThisMonthUserCount = _userService.GetAdminDashboardCounts().Result.ThisMonthUserCount,
                ThisYearUserCount = _userService.GetAdminDashboardCounts().Result.ThisYearUserCount,

                ThisMonthRentCount = _rentService.GetAdminDashboardCounts().Result.ThisMonthRentCount,
                ThisYearRentCount = _rentService.GetAdminDashboardCounts().Result.ThisYearRentCount,

                ThisMonthStadiumCount = _stadiumService.GetAdminDashboardCounts().Result.ThisMonthStadiumCount,
                ThisYearStadiumCount = _stadiumService.GetAdminDashboardCounts().Result.ThisYearStadiumCount,

                ThisMonthCenterCount = _centerService.GetAdminDashboardCounts().Result.ThisMonthCenterCount,
                ThisYearCenterCount = _centerService.GetAdminDashboardCounts().Result.ThisYearCenterCount,
            });
        }
    }
}
