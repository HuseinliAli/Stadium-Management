using Framework.Entities;
using Framework.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rent : BaseEntity,IEntity
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
        public int StadiumId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Stadium Stadium { get; set; }
    }
}
