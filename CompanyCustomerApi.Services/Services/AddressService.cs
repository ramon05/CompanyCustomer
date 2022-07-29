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
    public interface IAddressService : IBaseService<Address, AddressDto> { }
    public class AddressService : BaseService<Address, AddressDto>, IAddressService
    {
        public AddressService(
            IMapper _mapper, 
            IAddressRepository _repository, 
            IValidator<AddressDto> _validator ) : base(_mapper, _repository, _validator)
        {  
        }
    }
}
