using CompanyCustomerApi.BI.Dtos;
using CompanyCustomerApi.BI.Validations;
using CompanyCustomerApi.Model.Entities;
using CompanyCustomerApi.Model.Repositories;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Services.Services
{
    public interface ICustomerService : IBaseService<Customer, CustomerDto> { }
    public class CustomerService : BaseService<Customer, CustomerDto>, ICustomerService
    {
        public CustomerService(
            IMapper _mapper,
            ICustomerRepository _repository, 
            IValidator<CustomerDto> _validator ) : base(_mapper, _repository, _validator)
        {  
        }
    }
}
