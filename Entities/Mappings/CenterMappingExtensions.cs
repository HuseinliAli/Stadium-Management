using Entities.Concrete;
using Entities.Dtos.Centers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mappings
{
    public static class CenterMappingExtensions
    {
        public static AddOrUpdateCenterDto AsAddUpdateDto(Center center)
        {
            return new() {
                Address = center.Address,
                Email = center.Email,
                Latitude = center.Latitude,
                Longitude = center.Longitude,
                Name = center.Name,
                Number = center.Number,
                CreatedAt = DateTime.Now,
                UserId = center.CreatedById
            };
        }

        public static AddOrUpdateCenterDto AsUpdateDto(Center center)
        {
            return new()
            {
                Address = center.Address,
                Email = center.Email,
                Latitude = center.Latitude,
                Longitude = center.Longitude,
                Name = center.Name,
                Number = center.Number,
                LastUpdatedAt = DateTime.Now,
                UserId = center.CreatedById
            };
        }

        public static Center AsAddEntity(AddOrUpdateCenterDto dto)
        {
            return new Center()
            {
                Address = dto.Address,
                Email = dto.Email,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                Name = dto.Name,
                Number = dto.Number,
                CreatedDate = DateTime.Now,
                CreatedById = dto.UserId
            };
        }
        public static Center AsUpdateEntity(AddOrUpdateCenterDto dto)
        {
            return new Center()
            {
                Address = dto.Address,
                Email = dto.Email,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                Name = dto.Name,
                Number = dto.Number,
                LastUpdatedDate = DateTime.Now,
                CreatedById = dto.UserId
            };
        }
    }
}
