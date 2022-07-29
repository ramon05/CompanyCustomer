using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Core.BaseModel
{
    public interface IBaseDto
    {
        public int Id { get; set; }
        public Boolean Deleted { get; set; }
    }
    public class BaseDto : IBaseDto
    {
        public virtual int Id { get; set; }
        public virtual Boolean Deleted { get; set; }
    }
}
