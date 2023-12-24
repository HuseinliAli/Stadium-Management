using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Stadiums
{
    public class StadiumDto:IDto
    {
        public int StadiumId { get; set; }
        public string HallName { get; set; }
        public string StadiumPictureUrl { get; set; }
        public double PriceMorning { get; set; }
        public double PriceAfternoon { get; set; }
        public double PriceEvening { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
