using CompanyCustomerApi.Model.Contexts;
using CompanyCustomerApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Repositories
{
    public interface ICustomerAddressRepository : IBaseRepository<CustomerAddress> { }
    public class CustomerAddressRepository : BaseRepository<CustomerAddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(CompanyCustomerDbContext context) : base(context)
        {  
        }
    }
}
