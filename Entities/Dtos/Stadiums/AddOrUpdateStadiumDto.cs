using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Stadiums
{
    public class AddOrUpdateStadiumDto : IDto
    {
        public string HallName { get; set; }
        public string PictureUrl { get; set; }
        public double PriceMorning { get; set; }
        public double PriceAfternoon { get; set; }
        public double PriceEvening { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int UserId { get; set; }
        public int CenterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
