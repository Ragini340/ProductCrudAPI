using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NcsmigrateLog
    {
        public int CopyDocsRequestId { get; set; }
        public int FileId { get; set; }
        public int UserId { get; set; }
        public int DocumentCount { get; set; }
        public byte ProcessedFlag { get; set; }
        public DateTime LogDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? LogComments { get; set; }
        public short? IsOnlyImage { get; set; }
    }
}
