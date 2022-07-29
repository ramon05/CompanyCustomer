using CompanyCustomerApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Model.Entities
{
    public class Address : BaseEntity
    {
        public Address()
        {
            Customers = new HashSet<CustomerAddress>();
        }
        public string Description { get; set; }
        public string province { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        
        public virtual ICollection<CustomerAddress> Customers { get; set; } 
    }
}
