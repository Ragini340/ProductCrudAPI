using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DisbursementTrackInfo
    {
        public int DisbursementTrackInfoId { get; set; }
        public int DisbursementId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public string? Track { get; set; }
        public string? TrackNote { get; set; }
        public int? ServiceFileNoteId { get; set; }

        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual ServiceFileNote? ServiceFileNote { get; set; }
        public virtual TypeCdDmt? StatusTypeCd { get; set; }
    }
}
