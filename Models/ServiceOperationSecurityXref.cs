using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceOperationSecurityXref
    {
        public int OperationId { get; set; }
        public int SecurityLevelId { get; set; }
        public int ActivityGrpId { get; set; }
        public int ActivityId { get; set; }
        public string? UsageType { get; set; }

        public virtual Activity Activity { get; set; } = null!;
        public virtual ActivityGrp ActivityGrp { get; set; } = null!;
        public virtual ServiceOperation Operation { get; set; } = null!;
    }
}
