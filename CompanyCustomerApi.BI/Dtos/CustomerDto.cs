using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.BI.Dtos
{
    public class CustomerDto : BaseEntityDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string lastName { get; set; }
        public string SecondlastName { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
    }
}
