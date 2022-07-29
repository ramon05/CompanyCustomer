using CompanyCustomerApi.BI.Validations;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Config
{
    public static class FluentValidationConfig
    {
        public static IMvcBuilder configFluentValidation(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(x =>
            {
                x.AutomaticValidationEnabled = false;
                x.RegisterValidatorsFromAssemblyContaining<CustomerValidator>();
            });

            return builder;
        }
    }
}
