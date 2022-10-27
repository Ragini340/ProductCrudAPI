using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RateType
    {
        public RateType()
        {
            ServiceFileFees = new HashSet<ServiceFileFee>();
            ServiceFiles = new HashSet<ServiceFile>();
        }

        public int RateTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? Descr { get; set; }
        public byte? FeeType { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
    }
}
