using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RemittanceRequestQueue
    {
        public RemittanceRequestQueue()
        {
            AgentNetRemittances = new HashSet<AgentNetRemittance>();
        }

        public int RemitBatchId { get; set; }
        public string? RequestFileIds { get; set; }
        public string? RemitRequestXml { get; set; }
        public string? RemitResponseXml { get; set; }
        public int? StatusCd { get; set; }
        public DateTime? ProcessStartTime { get; set; }
        public DateTime? ProcessEndTime { get; set; }

        public virtual ICollection<AgentNetRemittance> AgentNetRemittances { get; set; }
    }
}
