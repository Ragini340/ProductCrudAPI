using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GenericEmail
    {
        public int GenericEmailId { get; set; }
        public DateTime? DateSent { get; set; }
        public string? Sentby { get; set; }
        public string? SubjectLine { get; set; }
        public int FileId { get; set; }
        public string? Emailmessage { get; set; }
        public string? Nameofattachments { get; set; }
        public short? AttachmentFlag { get; set; }
        public string? Cc { get; set; }
        public string? SendTo { get; set; }
        public int? UserId { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
        public virtual Employee? User { get; set; }
    }
}
