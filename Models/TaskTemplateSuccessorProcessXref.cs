using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateSuccessorProcessXref
    {
        public int TaskTemplateId { get; set; }
        public int ProcessTypeId { get; set; }
        public int? SuccessorStatusCd { get; set; }
        public byte? SeqNum { get; set; }
        public byte? DirSeqNum { get; set; }
        public int TaskTemplateSuccessorProcessXrefId { get; set; }
    }
}
