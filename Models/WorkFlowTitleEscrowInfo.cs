using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTitleEscrowInfo
    {
        public int TitleEscrowInfoId { get; set; }
        public DateTime? TcissuedDate { get; set; }
        public DateTime? TcexpirationDate { get; set; }
        public int? DaysToExpirationDate { get; set; }
        public DateTime? OrderReceivedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? DaysToOption { get; set; }
        public string? CommitmentDue { get; set; }
        public string? SurveyDue { get; set; }
        public string? AddendumDue { get; set; }

        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;
    }
}
