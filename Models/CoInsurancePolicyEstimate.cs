using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CoInsurancePolicyEstimate
    {
        public int CoInsuranceEstimateId { get; set; }
        public int CoInsurancePolicyId { get; set; }
        public int FileId { get; set; }
        public int? BusOrgId { get; set; }
        public short? IsLeadCoInsurer { get; set; }
        public string? PolicyNumber { get; set; }
        public decimal? Jsliability { get; set; }
        public decimal? PolicyLiability { get; set; }
        public string? LiabilityShare { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg? BusOrg { get; set; }
        public virtual CoInsurancePolicy CoInsurancePolicy { get; set; } = null!;
    }
}
