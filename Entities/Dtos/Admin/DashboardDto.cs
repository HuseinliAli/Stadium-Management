using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Admin
{
    public class DashboardDto:IDto
    {
        public int ThisMonthUserCount { get; set; }
        public int ThisMonthCenterCount { get; set; }
        public int ThisMonthRentCount { get; set; }
        public int ThisMonthStadiumCount { get; set; }
        public int ThisYearUserCount { get; set; }
        public int ThisYearCenterCount { get; set; }
        public int ThisYearRentCount { get; set; }
        public int ThisYearStadiumCount { get; set; }
    }
}
