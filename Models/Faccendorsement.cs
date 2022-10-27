using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Faccendorsement
    {
        public int FaccendorsementId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int? TitlePolicyTypecdId { get; set; }
        public int? ExternalFaccendorsementId { get; set; }
        public string? FaccendorsementDescr { get; set; }
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
        public int? EndRowSeqNum { get; set; }
        public DateTime? Effectivedate { get; set; }
        public int? FacctitlePolicyId { get; set; }
        public byte GroupId { get; set; }
        public string? OverrideReasonObjectCd { get; set; }
        public string? OverrideReason { get; set; }
        public int? SuperFaccendorsementId { get; set; }
        public byte? SrseqNum { get; set; }

        public virtual FacctitlePolicy? FacctitlePolicy { get; set; }
        public virtual Employee? OverRideEmployee { get; set; }
        public virtual TypeCdDmt? OverRideTypecd { get; set; }
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
        public virtual TypeCdDmt? TitlePolicyTypecd { get; set; }
    }
}
