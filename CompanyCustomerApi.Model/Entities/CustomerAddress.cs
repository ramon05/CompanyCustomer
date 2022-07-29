using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Entities
{
    public class CustomerAddress : BaseEntity
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer  { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

    }
}
