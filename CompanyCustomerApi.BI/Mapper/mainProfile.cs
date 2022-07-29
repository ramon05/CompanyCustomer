using CompanyCustomerApi.BI.Dtos;
using CompanyCustomerApi.Model.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Mapper
{
    public class mainProfile : Profile
    {
        public mainProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            CreateMap<Address, AddressDto>();
            CreateMap<AddressDto, Address>();

            CreateMap<CustomerAddress, CustomerAddressDto>();
            CreateMap<CustomerAddressDto, CustomerAddress>();

            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();
        }
    }
}
