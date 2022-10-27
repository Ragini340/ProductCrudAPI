using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PurgeDetail
    {
        public int Id { get; set; }
        public string TableName { get; set; } = null!;
        public short PurgeInHours { get; set; }
        public long PurgeByCount { get; set; }
        public string TimeStampColName { get; set; } = null!;
        public DateTime? LastPurgeTimeStamp { get; set; }
        public string? LastPurgeBy { get; set; }
    }
}
