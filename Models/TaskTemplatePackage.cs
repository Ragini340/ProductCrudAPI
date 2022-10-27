using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplatePackage
    {
        public TaskTemplatePackage()
        {
            TaskTemplatePackageDetails = new HashSet<TaskTemplatePackageDetail>();
            TaskTemplatePackageSuccessorProcesses = new HashSet<TaskTemplatePackageSuccessorProcess>();
        }

        public int TaskTemplatePackageId { get; set; }
        public string PackageName { get; set; } = null!;
        public short PackageType { get; set; }
        public int? TaskTemplateSuccessorStatusId { get; set; }
        public int TaskTemplateId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TaskTemplateSuccessorStatus? TaskTemplateSuccessorStatus { get; set; }
        public virtual ICollection<TaskTemplatePackageDetail> TaskTemplatePackageDetails { get; set; }
        public virtual ICollection<TaskTemplatePackageSuccessorProcess> TaskTemplatePackageSuccessorProcesses { get; set; }
    }
}
