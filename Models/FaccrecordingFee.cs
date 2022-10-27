using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccrecordingFee
    {
        public int FaccrecordingFeeId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int? RecordingDocumentId { get; set; }
        public string? RecordingDocumentDescr { get; set; }
        public int Pages { get; set; }
        public decimal ConsiderationAmount { get; set; }
        public int Seqnum { get; set; }
        public int? SuperRecordId { get; set; }
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
        public int? GrpSeqNum { get; set; }
        public string? OverrideReasonObjectCd { get; set; }
        public string? OverrideReason { get; set; }

        public virtual Employee? OverRideEmployee { get; set; }
        public virtual TypeCdDmt? OverRideTypecd { get; set; }
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
