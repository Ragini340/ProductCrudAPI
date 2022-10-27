using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NpidataEncryptionStatus
    {
        public long Id { get; set; }
        public long TextId { get; set; }
        public string InstanceName { get; set; } = null!;
        public int Statuscd { get; set; }
        public string? Comments { get; set; }
        public DateTime? StatusChangeDate { get; set; }
    }
}
