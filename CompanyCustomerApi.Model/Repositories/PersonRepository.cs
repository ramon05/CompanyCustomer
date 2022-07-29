using CompanyCustomerApi.Model.Contexts;
using CompanyCustomerApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer> { }
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CompanyCustomerDbContext context) : base(context)
        {  
        }
    }
}
