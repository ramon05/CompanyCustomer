using CompanyCustomerApi.BI.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Validations
{
    public class CompanyValidator : AbstractValidator<CompanyDto>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Company's Description is required");
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Company's Name is required");
            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Company's Phone is required");
        }
    }
}
