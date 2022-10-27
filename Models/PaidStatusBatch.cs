using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PaidStatusBatch
    {
        public PaidStatusBatch()
        {
            PaidStatusLogs = new HashSet<PaidStatusLog>();
        }

        public int BatchId { get; set; }
        public byte? Processed { get; set; }
        public string? RequestXml { get; set; }
        public string? ResponseXml { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedKey { get; set; }

        public virtual ICollection<PaidStatusLog> PaidStatusLogs { get; set; }
    }
}
