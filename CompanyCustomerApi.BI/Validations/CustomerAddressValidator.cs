using CompanyCustomerApi.BI.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Validations
{
    public class CustomerAddressValidator : AbstractValidator<CustomerAddressDto>
    {
        public CustomerAddressValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty()
                .WithMessage("CustomerPhone's Customer is required");
            RuleFor(x => x.AddressId)
                .NotEmpty()
                .WithMessage("CustomerPhone's Phone is required");
        }
    }
}
