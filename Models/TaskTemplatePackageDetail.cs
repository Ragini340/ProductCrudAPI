using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplatePackageDetail
    {
        public int TaskTemplatePackageDetailsId { get; set; }
        public int? TaskTemplatePackageId { get; set; }
        public int? SuccessorTaskTemplateId { get; set; }
        public short SuccessorStatusCd { get; set; }
        public short? ManualUpdateFlag { get; set; }
        public short? InheritFlag { get; set; }
        public short? SeqNum { get; set; }

        public virtual TaskTemplate? SuccessorTaskTemplate { get; set; }
        public virtual TaskTemplatePackage? TaskTemplatePackage { get; set; }
    }
}
