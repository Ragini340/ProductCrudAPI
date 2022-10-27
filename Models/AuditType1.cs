using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AuditType1
    {
        public int AuditTypeId { get; set; }
        public string Name { get; set; } = null!;
    }
}
