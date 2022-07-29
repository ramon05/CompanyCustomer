using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyCustomerApi.Core.BaseModel
{
    public interface IBaseEntity : IBase
    {
      public  DateTimeOffset? DeletedDate { get; set; }
      public  DateTimeOffset CreatedDate { get; set; }
      public  DateTimeOffset? UpdatedDate { get; set; }
      public  string CreatedBy { get; set; }
      public  string DeletedBy { get; set; }
      public  string UpdatedBy { get; set; }
    }
    public class BaseEntity :Base, IBaseEntity
    {
       public virtual DateTimeOffset? DeletedDate { get; set; }
       public virtual DateTimeOffset CreatedDate { get; set; }
       public virtual DateTimeOffset? UpdatedDate { get; set; }
       public virtual string CreatedBy { get; set; }
       public virtual string DeletedBy { get; set; }
       public virtual string UpdatedBy { get; set; }
    }
}
