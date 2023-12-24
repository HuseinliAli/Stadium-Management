using Entities.Concrete;
using Entities.Dtos.Rents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mappings
{
    public class RentMappingExtensions
    {
        public static Rent AsAddEntity(AddOrUpdateRentDto dto)
        {
            return new()
            {
                StadiumId = dto.StadiumId,
                CreatedDate = DateTime.Now,
                Finish = dto.Finish,
                Start = dto.Start,
                Price = dto.Price,
                Tax = dto.Tax,
                TotalPrice = dto.TotalPrice,
                UserId = dto.UserId
            };
        }

        public static Rent AsUpdateEntity(Rent rent,AddOrUpdateRentDto dto)
        {
            rent.Start = dto.Start;
            rent.Finish = dto.Finish;
            rent.Price = dto.Price;
            rent.TotalPrice = dto.TotalPrice;
            rent.Tax = dto.Tax;
            rent.LastUpdatedDate = DateTime.Now;
            rent.UserId = dto.UserId;
            rent.StadiumId = dto.StadiumId;
            return rent;
        }

        public static AddOrUpdateRentDto AsUpdateDto(Rent rent)
        {
            return new()
            {
                StadiumId = rent.StadiumId,
                LastUpdatedDate = DateTime.Now,
                Finish = rent.Finish,
                Start = rent.Start,
                Price = rent.Price,
                Tax = rent.Tax,
                TotalPrice = rent.TotalPrice,
                UserId = rent.UserId
            };
        }
        public static AddOrUpdateRentDto AsAddDto(Rent rent)
        {
            return new()
            {
                StadiumId = rent.StadiumId,
                CreatedDate = DateTime.Now,
                Finish = rent.Finish,
                Start = rent.Start,
                Price = rent.Price,
                Tax = rent.Tax,
                TotalPrice = rent.TotalPrice,
                UserId = rent.UserId
            };
        }
    }
}
