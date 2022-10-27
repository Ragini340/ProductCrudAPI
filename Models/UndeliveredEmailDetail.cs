using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UndeliveredEmailDetail
    {
        public int UndeliveredEmailDetailId { get; set; }
        public int? FileId { get; set; }
        public long? DeliveryEventLogId { get; set; }
        public int? BusinessUnitId { get; set; }
        public string? SenderEmailAddress { get; set; }
        public string? RecipientEmailAddress { get; set; }
        public string? SubjectLine { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? FileNum { get; set; }
        public string? Comments { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual ServiceFile? File { get; set; }
    }
}
