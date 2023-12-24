using Entities.Dtos.Rents;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.FluentValidation.Rent
{
    public class RentValidator : AbstractValidator<AddOrUpdateRentDto>
    {
        public RentValidator()
        {
            RuleFor(r => r.Start).NotEmpty();
            RuleFor(r => r.StadiumId).NotEmpty();
            RuleFor(r => r.UserId).NotEmpty();
        }
    }
}
