using Framework.Entities;
using Framework.Entities.Users;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{

    public class Stadium:BaseEntity,IEntity
    {
        public string HallName { get; set; }
        public string PictureUrl { get; set; }
        public double PriceMorning { get; set; }
        public double PriceAfternoon { get; set; }
        public double PriceEvening { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int CenterId { get; set; }
        public int CreatedById { get; set; }

        public virtual User User { get; set; }
        public virtual Center Center { get; set; }
    }

}
