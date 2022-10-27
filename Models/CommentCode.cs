using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CommentCode
    {
        public int CommentCodeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? Description { get; set; }
        public int StatusCd { get; set; }
        public short CanModifyFlag { get; set; }
        public int BusinessUnitId { get; set; }
        public string? Comments { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastActivatedBy { get; set; }
        public DateTime? LastActivatedDate { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public int? DeactivatedBy { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
