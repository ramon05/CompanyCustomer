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
    public interface ICompanyService : IBaseService<Company, CompanyDto> { }
    public class CompanyService : BaseService<Company, CompanyDto>, ICompanyService
    {
        public CompanyService(
            IMapper _mapper, 
            ICompanyRepository _repository, 
            IValidator<CompanyDto> _validator ) : base(_mapper, _repository, _validator)
        {  
        }
    }
}
