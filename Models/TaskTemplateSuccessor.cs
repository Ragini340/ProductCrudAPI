using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateSuccessor
    {
        public int TaskTemplateSuccessorId { get; set; }
        public int TaskTemplateId { get; set; }
        public int SuccessorTaskTemplateId { get; set; }
        public int ConditionalStatusCd { get; set; }
        public short ManualUpdateFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? DirectingStatusCd { get; set; }
        public byte? SeqNum { get; set; }
        public short? InheritFlg { get; set; }
    }
}
