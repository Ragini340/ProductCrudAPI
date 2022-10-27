using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LicenseInformationLog
    {
        public int LicenseInformationLogId { get; set; }
        public int LicenseInformationId { get; set; }
        public int EventTypeId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Employee CreationUser { get; set; } = null!;
        public virtual TypeCdDmt EventType { get; set; } = null!;
        public virtual LicenseInformation LicenseInformation { get; set; } = null!;
    }
}
