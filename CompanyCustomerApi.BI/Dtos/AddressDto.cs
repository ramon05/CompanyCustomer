using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Dtos
{
    public class AddressDto : BaseEntityDto
    {
        public string Description { get; set; }
        public string province { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
    }
}
