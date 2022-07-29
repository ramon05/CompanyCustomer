using CompanyCustomerApi.BI.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Validations
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Customer's Name is required");
            RuleFor(x => x.lastName)
                .NotEmpty()
                .WithMessage("Customer's LastName is required");
            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Customer's Phone is required");
        }
    }
}
