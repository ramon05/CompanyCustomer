using CompanyCustomerApi.Model.Contexts;
using CompanyCustomerApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Repositories
{
    public interface IAddressRepository : IBaseRepository<Address> { }
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(CompanyCustomerDbContext context) : base(context)
        {  
        }
    }
}
