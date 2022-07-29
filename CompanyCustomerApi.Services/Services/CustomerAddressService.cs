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
    public interface ICustomerAddressService : IBaseService<CustomerAddress, CustomerAddressDto> { }
    public class CustomerAddressService : BaseService<CustomerAddress, CustomerAddressDto>, ICustomerAddressService
    {
        public CustomerAddressService(
            IMapper _mapper, 
            ICustomerAddressRepository _repository, 
            IValidator<CustomerAddressDto> _validator ) : base(_mapper, _repository, _validator)
        {  
        }
    }
}
