using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceOperation
    {
        public ServiceOperation()
        {
            ServiceOperationApplicationXrefs = new HashSet<ServiceOperationApplicationXref>();
            ServiceOperationSecurityXrefs = new HashSet<ServiceOperationSecurityXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ServiceOperationApplicationXref> ServiceOperationApplicationXrefs { get; set; }
        public virtual ICollection<ServiceOperationSecurityXref> ServiceOperationSecurityXrefs { get; set; }
    }
}
