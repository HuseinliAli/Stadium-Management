using Framework.Entities;

namespace Entities.Dtos.Stadiums
{
    public class StadiumWithCenterDto : IDto
    {
        public int StadiumId { get; set; }
        public string StadiumHallName { get; set; }
        public string StadiumPictureUrl { get; set; }
        public double StadiumPriceMorning { get; set; }
        public double StadiumPriceAfternoon { get; set; }
        public double StadiumPriceEvening { get; set; }
        public DateTime StadiumOpenTime { get; set; }
        public DateTime StadiumCloseTime { get; set; }
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public string CenterAddress { get; set; }
        public double CenterLatitude { get; set; }
        public double CenterLongitude { get; set; }
        public string CenterEmail { get; set; }
        public string CenterNumber { get; set; }
    }
}
