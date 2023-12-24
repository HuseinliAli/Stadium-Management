using Entities.Concrete;
using Entities.Dtos.Stadiums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mappings
{
    public static class StadiumMappingExtensions
    {
        public static Stadium AsAddEntity(AddOrUpdateStadiumDto dto)
        {
            return new Stadium()
            {
                HallName = dto.HallName,
                PictureUrl = dto.PictureUrl,
                PriceAfternoon = dto.PriceAfternoon,
                PriceEvening = dto.PriceEvening,
                PriceMorning = dto.PriceMorning,
                CloseTime = dto.CloseTime,
                OpenTime = dto.OpenTime,
                CenterId = dto.CenterId,
                CreatedDate = DateTime.Now,
                CreatedById = dto.UserId
            };
        }

        public static AddOrUpdateStadiumDto AsAddDto(Stadium s)
        {
            return new()
            {
                HallName = s.HallName,
                PictureUrl = s.PictureUrl,
                PriceAfternoon = s.PriceAfternoon,
                PriceEvening = s.PriceEvening,
                PriceMorning = s.PriceMorning,
                CloseTime = s.CloseTime,
                OpenTime = s.OpenTime,
                CenterId = s.CenterId,
                CreatedAt = DateTime.Now,
                UserId = s.CreatedById
            };
        }
        public static AddOrUpdateStadiumDto AsUpdateDto(Stadium s)
        {
            return new()
            {
                HallName = s.HallName,
                PictureUrl = s.PictureUrl,
                PriceAfternoon = s.PriceAfternoon,
                PriceEvening = s.PriceEvening,
                PriceMorning = s.PriceMorning,
                CloseTime = s.CloseTime,
                OpenTime = s.OpenTime,
                CenterId = s.CenterId,
                LastUpdatedAt = DateTime.Now,
                UserId = s.CreatedById
            };
        }
        public static Stadium AsUpdateEntity(AddOrUpdateStadiumDto dto)
        {
            return new Stadium()
            {
                HallName = dto.HallName,
                PictureUrl = dto.PictureUrl,
                PriceAfternoon = dto.PriceAfternoon,
                PriceEvening = dto.PriceEvening,
                PriceMorning = dto.PriceMorning,
                CloseTime = dto.CloseTime,
                OpenTime = dto.OpenTime,
                CenterId = dto.CenterId,
                LastUpdatedDate = DateTime.Now,
                CreatedById = dto.UserId
            };
        }

        public static StadiumDto AsSelectStadiumDto(Stadium s)
        {
            return new StadiumDto
            {
                StadiumId = s.Id,
                HallName = s.HallName,
                StadiumPictureUrl = s.PictureUrl,
                PriceMorning = s.PriceMorning,
                PriceAfternoon = s.PriceAfternoon,
                PriceEvening = s.PriceEvening,
                OpenTime = s.OpenTime,
                CloseTime = s.CloseTime,
                CreatedDate = s.CreatedDate,
                LastUpdatedDate = s.LastUpdatedDate
            };
        }
    }
}
