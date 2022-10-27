using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateCommentCodeXref
    {
        public int TaskTemplateCommentCodeXrefId { get; set; }
        public int TaskTemplateId { get; set; }
        public int CommentCodeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
