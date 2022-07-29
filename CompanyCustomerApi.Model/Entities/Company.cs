using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Entities
{
    public class Company : BaseEntity
    {
        public Company()
        {
            Customers = new HashSet<Customer>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
