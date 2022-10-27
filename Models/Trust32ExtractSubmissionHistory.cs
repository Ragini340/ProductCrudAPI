using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Trust32ExtractSubmissionHistory
    {
        public int? BusinessUnitId { get; set; }
        public DateTime? ExtractCutOffDateTime { get; set; }
        public DateTime? SubmittedTime { get; set; }
        public DateTime? ExecStartTime { get; set; }
        public DateTime? ExecEndTime { get; set; }
        public int Trust32ExtractSubmissionHistoryId { get; set; }
        public string? ExtractType { get; set; }
    }
}
