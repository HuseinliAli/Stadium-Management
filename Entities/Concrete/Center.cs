using Framework.Entities;
using Framework.Entities.Users;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Center : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public int CreatedById { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Stadium> Stadiums{get;set;}
    }
}
