using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class MdmdataTruncationLog
    {
        public int MdmdataTruncationLogId { get; set; }
        public int RegionId { get; set; }
        public string? BusinessEntityType { get; set; }
        public long ParentEntepriseId { get; set; }
        public int RecordTypeId { get; set; }
        public long RecordEnterpriseId { get; set; }
        public string? FieldName { get; set; }
        public string? OriginalValue { get; set; }
        public string? StoredValue { get; set; }
        public DateTime LogDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
