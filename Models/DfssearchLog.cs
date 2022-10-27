using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DfssearchLog
    {
        public int SearchLogId { get; set; }
        public string ObjectName { get; set; } = null!;
        public int ObjectKey { get; set; }
        public long ObjectUpdTs { get; set; }
        public byte? TranType { get; set; }
        public int? FileId { get; set; }
        public string? OtherInfo { get; set; }
        public byte? StatusCd { get; set; }
        public DateTime? SubmittedTime { get; set; }
        public string? HostIp { get; set; }
        public DateTime? RequestedTime { get; set; }
        public DateTime? CompletedTime { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? Comments { get; set; }
        public string OtherInfo1 { get; set; } = null!;
    }
}
