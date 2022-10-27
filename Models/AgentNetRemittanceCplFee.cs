using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AgentNetRemittanceCplFee
    {
        public int AgentNetCplId { get; set; }
        public int FileId { get; set; }
        public int CplProductId { get; set; }
        public int CplCoveredPartyId { get; set; }
        public string? CplCoveredPartyName { get; set; }
        public int ServiceFileFeeId { get; set; }
        public string? FeeDesc { get; set; }
        public int CplTypeId { get; set; }
        public string? LetterType { get; set; }
        public string? RequestedBy { get; set; }
        public DateTime? RequestedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
    }
}
