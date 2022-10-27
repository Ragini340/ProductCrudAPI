using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TmpTaskBcp
    {
        public int ThreadId { get; set; }
        public string? TableName { get; set; }
        public int? Interval { get; set; }
        public int? BeginId { get; set; }
        public int? EndId { get; set; }
        public int? BatchCount { get; set; }
        public string? SqlFormat { get; set; }
        public string? SqlOut { get; set; }
        public string? SqlIn { get; set; }
        public string? DelTxt { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Status { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
