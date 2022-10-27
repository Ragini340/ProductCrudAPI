using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgVersionLog
    {
        public int BusOrgVersionLogId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? OldVersionId { get; set; }
        public int? NewVersionId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
