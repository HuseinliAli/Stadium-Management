using Entities.Concrete;
using Entities.Dtos.Stadiums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.FluentValidation
{
    public class StadiumValidator : AbstractValidator<AddOrUpdateStadiumDto>
    {
        public StadiumValidator()
        {
            RuleFor(c=>c.HallName).NotEmpty();
            RuleFor(c => c.HallName).MaximumLength(100);
           
            RuleFor(c => c.PriceMorning).NotEmpty();
            RuleFor(c => c.PriceEvening).NotEmpty();
            RuleFor(c => c.PriceAfternoon).NotEmpty();
        }
    }
}
