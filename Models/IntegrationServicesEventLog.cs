using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IntegrationServicesEventLog
    {
        public long IseventLogId { get; set; }
        public int ClassTypeId { get; set; }
        public int? FileId { get; set; }
        public int EventId { get; set; }
        public int? StatusCd { get; set; }
        public string? Comments { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int EventSourceId { get; set; }
        public int EventSourceClassTypeId { get; set; }
        public int? UpdSourceId { get; set; }
        public int? UpdSourceClassTypeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Event Event { get; set; } = null!;
        public virtual ClassType EventSourceClassType { get; set; } = null!;
        public virtual ServiceFile? File { get; set; }
        public virtual EventLogKey IseventLog { get; set; } = null!;
        public virtual ClassType? UpdSourceClassType { get; set; }
    }
}
