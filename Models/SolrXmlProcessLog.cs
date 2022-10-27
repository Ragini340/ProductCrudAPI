using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SolrXmlProcessLog
    {
        public int Id { get; set; }
        public int? BatchId { get; set; }
        public int? RegionId { get; set; }
        public int? StepId { get; set; }
        public string? XmlFilePath { get; set; }
        public short? Status { get; set; }
        public string? StatusDescription { get; set; }
        public string? PackageName { get; set; }
        public string? TaskName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
