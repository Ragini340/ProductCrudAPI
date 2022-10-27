using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccbusinessSegmentXref
    {
        public int BusinessSegmentId { get; set; }
        public string BusinessSegmentCode { get; set; } = null!;
        public string BusinessSegmentName { get; set; } = null!;
        public int FaccbusinessSegmentId { get; set; }
        public string FaccbusinessSegmentName { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt BusinessSegment { get; set; } = null!;
    }
}
