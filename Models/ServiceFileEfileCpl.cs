using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileEfileCpl
    {
        public int ServiceFileEfileCplid { get; set; }
        public int ServiceFileId { get; set; }
        public int ElectronicFileId { get; set; }
        public int ProductResponseId { get; set; }
        public int AgentNetFileId { get; set; }
        public int AgentNetOfficeId { get; set; }
        public int AgentNetFirmId { get; set; }
        public int ProductTypeId { get; set; }
        public string ClientRequestIdtext { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? AgentNetUnderwriterCode { get; set; }
    }
}
