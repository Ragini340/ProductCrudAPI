using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GfeagtUwsplitInfo
    {
        public int GfeagtUwsplitInfoId { get; set; }
        public int FileId { get; set; }
        public string? UwdefaultPayTo { get; set; }
        public decimal? UwdefaultPct { get; set; }
        public int? UwoverridePayToFlag { get; set; }
        public string? UwoverridePayTo { get; set; }
        public int? UwoverridePctFlag { get; set; }
        public decimal? UwoverridePct { get; set; }
        public string? Agt1DefaultPayTo { get; set; }
        public int? Agt1OverridePayToFlag { get; set; }
        public string? Agt1OverridePayTo { get; set; }
        public string? Agt2PayTo { get; set; }
        public decimal? Agt2Pct { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? UwcalType { get; set; }
        public decimal? UwsplitAmount { get; set; }
        public int? Agt1CalType { get; set; }
        public decimal? Agt1Pct { get; set; }
        public decimal? Agt1SplitAmount { get; set; }
        public int? Agt2CalType { get; set; }
        public decimal? Agt2SplitAmount { get; set; }
        public decimal? FstUwdpct { get; set; }
        public short? Agt2OverridePayToFlag { get; set; }
        public string? Agt2OverridePayTo { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
