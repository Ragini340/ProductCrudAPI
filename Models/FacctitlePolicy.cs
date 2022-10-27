using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FacctitlePolicy
    {
        public FacctitlePolicy()
        {
            Faccendorsements = new HashSet<Faccendorsement>();
            InverseSuperFacctitlePolicy = new HashSet<FacctitlePolicy>();
        }

        public int FacctitlePolicyId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int? TitlePolicyTypecdId { get; set; }
        public short? Simul { get; set; }
        public int? FaccrateTypeId { get; set; }
        public string? FaccrateTypeDescr { get; set; }
        public DateTime? Effectivedate { get; set; }
        public int Seqnum { get; set; }
        public bool? IsFacc { get; set; }
        public int? OverRideTypecdId { get; set; }
        public decimal? Amount { get; set; }
        public int? ChargeToCdId { get; set; }
        public int? SplitPercent { get; set; }
        public decimal? SplitAmount { get; set; }
        public decimal? Faccamount { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? OverRideEmployeeId { get; set; }
        public string? FacctitlePolicyDescr { get; set; }
        public decimal? FaccadjustedAmount { get; set; }
        public decimal? AdjustedAmount { get; set; }
        public int? SuperFacctitlePolicyId { get; set; }
        public decimal? GuaranteeLiabAmount { get; set; }
        public byte GroupId { get; set; }
        public short LinkKey { get; set; }
        public string? OverrideReasonObjectCd { get; set; }
        public string? OverrideReason { get; set; }

        public virtual Employee? OverRideEmployee { get; set; }
        public virtual TypeCdDmt? OverRideTypecd { get; set; }
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
        public virtual FacctitlePolicy? SuperFacctitlePolicy { get; set; }
        public virtual ICollection<Faccendorsement> Faccendorsements { get; set; }
        public virtual ICollection<FacctitlePolicy> InverseSuperFacctitlePolicy { get; set; }
    }
}
