using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SdnsearchHit
    {
        public int FileId { get; set; }
        public string? OriginalName { get; set; }
        public string? HitNames { get; set; }
        public short? EmailNotificationFlag { get; set; }
        public string? EmailReceipientName { get; set; }
        public short? ProcessFlag { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? Updateddate { get; set; }
        public byte[]? UpdTs { get; set; }
        public int SdnsearchHitId { get; set; }
    }
}
