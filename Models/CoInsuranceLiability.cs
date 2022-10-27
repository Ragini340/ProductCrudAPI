using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CoInsuranceLiability
    {
        public int CoInsuranceLiabilityId { get; set; }
        public int FileId { get; set; }
        public decimal? OverallLiability { get; set; }
        public decimal? Faliability { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
    }
}
