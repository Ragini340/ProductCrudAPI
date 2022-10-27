using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceUserAccountApplicationXref
    {
        public int ApplicationId { get; set; }
        public int AccountId { get; set; }
        public string Type { get; set; } = null!;

        public virtual ServiceUserAccount Account { get; set; } = null!;
        public virtual Application Application { get; set; } = null!;
    }
}
