using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AgentNetPolicyNumber
    {
        public AgentNetPolicyNumber()
        {
            PolicyUnderwriterXrefs = new HashSet<PolicyUnderwriterXref>();
        }

        public int AgentNetPolicyNumberId { get; set; }
        public int AgentNetJacketId { get; set; }
        public int FileId { get; set; }
        public string? PolicyNumber { get; set; }
        public string AgentNetJacketType { get; set; } = null!;
        public int TypeCdId { get; set; }
        public string? VoidComments { get; set; }
        public int? UserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? ServiceFileFeeId { get; set; }
        public int? ProductTypeCdId { get; set; }
        public string? AgentNetUnderWriterCode { get; set; }
        public int? AgentNetOfficeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int AgentNetFirmId { get; set; }
        public int? AgentNetProductId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt? ProductTypeCd { get; set; }
        public virtual ServiceFileFee? ServiceFileFee { get; set; }
        public virtual TypeCdDmt TypeCd { get; set; } = null!;
        public virtual ICollection<PolicyUnderwriterXref> PolicyUnderwriterXrefs { get; set; }
    }
}
