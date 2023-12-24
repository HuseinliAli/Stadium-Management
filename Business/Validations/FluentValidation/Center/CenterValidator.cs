using Entities.Concrete;
using Entities.Dtos.Centers;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.FluentValidation.Center
{
    public class CenterValidator : AbstractValidator<AddOrUpdateCenterDto>
    {
        public CenterValidator()
        {
            RuleFor(c => c.Address).NotEmpty();
            //  RuleFor(c => c.Address).MinimumLength(10);
            RuleFor(c => c.Address).MaximumLength(200);

            RuleFor(c => c.Email).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();

            //RuleFor(c => c.Latitude).NotEmpty();
            //RuleFor(c => c.Longitude).NotEmpty();

            RuleFor(c => c.Number).MinimumLength(6);
            RuleFor(c => c.Name).NotEmpty();
            //RuleFor(c => c.Name).MinimumLength(5);
            RuleFor(c => c.Name).MaximumLength(150);
        }
    }
}
