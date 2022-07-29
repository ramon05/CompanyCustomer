using CompanyCustomerApi.Model.Contexts;
using CompanyCustomerApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Repositories
{
    public interface ICompanyRepository : IBaseRepository<Company> { }
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(CompanyCustomerDbContext context) : base(context)
        {  
        }
    }
}
