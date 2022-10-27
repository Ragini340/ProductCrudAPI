using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AgentNetRemittance
    {
        public int AgentNetRemittanceId { get; set; }
        public int FileId { get; set; }
        public int? AgentNetFileId { get; set; }
        public short? FileEligibilityStatus { get; set; }
        public short? RemittanceStatus { get; set; }
        public DateTime? PolicyEffectiveDate { get; set; }
        public decimal? GrossPremium { get; set; }
        public decimal? NetPremium { get; set; }
        public string? RemitXml { get; set; }
        public string? UserName { get; set; }
        public DateTime? RemittedDateTime { get; set; }
        public string? AgentNetUnderWriterCode { get; set; }
        public string? RemitResponseXml { get; set; }
        public string? RemitComments { get; set; }
        public decimal? AgentNetUnderWriterFeePercentage { get; set; }
        public int? RemitBatchId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int AgentNetFileStatus { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual RemittanceRequestQueue? RemitBatch { get; set; }
    }
}
