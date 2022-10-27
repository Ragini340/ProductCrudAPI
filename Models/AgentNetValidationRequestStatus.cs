using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AgentNetValidationRequestStatus
    {
        public int AgentNetValidationRequestId { get; set; }
        public int FastemployeeId { get; set; }
        public byte ValidationStatus { get; set; }
        public DateTime? RequestedDate { get; set; }

        public virtual Employee Fastemployee { get; set; } = null!;
    }
}
