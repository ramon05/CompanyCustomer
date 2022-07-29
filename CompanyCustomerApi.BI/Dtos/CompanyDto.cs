using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Dtos
{
    public class CompanyDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
    }
}
