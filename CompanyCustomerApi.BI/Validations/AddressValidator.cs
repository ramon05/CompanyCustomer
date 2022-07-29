using CompanyCustomerApi.BI.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Validations
{
    public class AddressValidator : AbstractValidator<AddressDto>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Address's Description is required");
            RuleFor(x => x.province)
                .NotEmpty()
                .WithMessage("Address's province is required");
            RuleFor(x => x.Neighborhood)
                .NotEmpty()
                .WithMessage("Address's Neighborhood is required");
            RuleFor(x => x.StreetNumber)
                .NotEmpty()
                .WithMessage("Address's StreetNumber is required");
        }
    }
}
