using Bogus;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Persistence.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concrete.EntityFramework.Seeding
{
    public static class DbSeed
    {
        public static void Init()
        {
            var centerFaker = new Faker<Center>("az")
                .RuleFor(i => i.Name, i => i.Name.LastName())
                .RuleFor(i => i.Latitude, i => i.Address.Latitude())
                .RuleFor(i => i.Longitude, i => i.Address.Longitude())
                .RuleFor(i => i.Email, i => i.Internet.Email())
                .RuleFor(i => i.Number, i => i.Phone.PhoneNumber());

            var stadiumFaker = new Faker<Stadium>("az")
                .RuleFor(i => i.HallName, i => i.Name.LastName())
                .RuleFor(i => i.PriceAfternoon, i => i.Random.Double(20, 100))
                .RuleFor(i => i.PriceEvening, i => i.Random.Double(20, 100))
                .RuleFor(i => i.PriceMorning, i => i.Random.Double(20, 100))
                .RuleFor(i=>i.PictureUrl, i=>i.Image.PlaceholderUrl(400,400))
                .RuleFor(i=>i.OpenTime, i=>i.Date.Recent(0))
                .RuleFor(i => i.CloseTime, i => i.Date.Recent(0))
                .RuleFor(i => i.Center , centerFaker);
            using (var context = new MiniStadiumRentDbContext())
            {
                context.Stadiums.AddRange(stadiumFaker.Generate(20));
                context.Centers.AddRange(centerFaker.Generate(20));
              
                context.SaveChanges();
            }    
        }
    }
}
