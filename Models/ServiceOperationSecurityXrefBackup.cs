using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceOperationSecurityXrefBackup
    {
        public int OperationId { get; set; }
        public int SecurityLevelId { get; set; }
        public int ActivityGrpId { get; set; }
        public int ActivityId { get; set; }
        public string? UsageType { get; set; }
        public int Isdeleted { get; set; }
        public DateTime OperationAppSecurityDeletedDate { get; set; }
    }
}
