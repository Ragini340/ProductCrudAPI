using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplatePackageSuccessorProcess
    {
        public int TaskTemplatePackageSuccessorProcessesId { get; set; }
        public int? TaskTemplatePackageId { get; set; }
        public int? ProcessTypeId { get; set; }
        public short? SeqNum { get; set; }

        public virtual ProcessType? ProcessType { get; set; }
        public virtual TaskTemplatePackage? TaskTemplatePackage { get; set; }
    }
}
