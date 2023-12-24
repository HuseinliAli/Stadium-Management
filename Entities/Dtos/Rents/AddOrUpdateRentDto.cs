using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Dtos.Rents
{
    public class AddOrUpdateRentDto : IDto
    {

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
        public int StadiumId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }

    public class GetDetailRentDto : IDto
    {
        public int Id { get; set; }
        public string StadiumName { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public double Price { get; set; }
        public int StadiumId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
