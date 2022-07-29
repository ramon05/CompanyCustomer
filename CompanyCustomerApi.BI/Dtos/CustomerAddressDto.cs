using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Dtos
{
    public class CustomerAddressDto : BaseEntityDto
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}
