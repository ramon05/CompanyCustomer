using CompanyCustomerApi.BI.Dtos;
using CompanyCustomerApi.Model.Entities;
using CompanyCustomerApi.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyCustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : BaseController<Company, CompanyDto>
    {
        public CompanyController(ICompanyService service) : base(service)
        {   
        }
    }
}
