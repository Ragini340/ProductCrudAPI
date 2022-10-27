using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceUserAccount
    {
        public ServiceUserAccount()
        {
            ServiceUserAccountApplicationXrefs = new HashSet<ServiceUserAccountApplicationXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? FastlinkAccess { get; set; }

        public virtual ICollection<ServiceUserAccountApplicationXref> ServiceUserAccountApplicationXrefs { get; set; }
    }
}
