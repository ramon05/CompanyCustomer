using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Core.BaseModel
{
    public interface IBase
    {
        public int Id { get; set; }
        public Boolean Deleted { get; set; }
    }
    public class Base : IBase
    {
        public virtual int Id { get; set; }
        public virtual Boolean Deleted { get; set; }
    }
}
