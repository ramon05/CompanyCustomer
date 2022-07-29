using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Address = new HashSet<CustomerAddress>();
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string lastName { get; set; }
        public string SecondlastName { get; set; }
        public string Phone { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }    
        public virtual ICollection<CustomerAddress> Address { get; set; }
    }
}
