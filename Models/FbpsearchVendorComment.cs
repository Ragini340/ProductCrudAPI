using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FbpsearchVendorComment
    {
        public int CommentId { get; set; }
        public string? VendorComments { get; set; }
        public int? FileProcessId { get; set; }
        public int? CreationUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte[] Updts { get; set; } = null!;
    }
}
