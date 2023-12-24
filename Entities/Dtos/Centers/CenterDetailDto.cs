using Framework.Entities;

namespace Entities.Dtos.Centers
{
    public class CenterDetailDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string CreatedBy { get; set; }
        public int StadiumCount { get; set; }
    }
}
