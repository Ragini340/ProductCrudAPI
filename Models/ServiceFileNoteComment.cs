using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileNoteComment
    {
        public int ServiceFileNoteId { get; set; }
        public string? UserLevel { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? Comments { get; set; }
        public byte[]? UpdTs { get; set; }
        public int ServiceFileNoteCommentsId { get; set; }

        public virtual ServiceFileNote ServiceFileNote { get; set; } = null!;
    }
}
