using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateSuccessorStatus
    {
        public TaskTemplateSuccessorStatus()
        {
            TaskTemplatePackages = new HashSet<TaskTemplatePackage>();
        }

        public int TaskTemplateSuccessorStatusId { get; set; }
        public int? TaskTemplateId { get; set; }
        public int? DirectingStatusCd { get; set; }
        public short Type { get; set; }

        public virtual TaskTemplate? TaskTemplate { get; set; }
        public virtual ICollection<TaskTemplatePackage> TaskTemplatePackages { get; set; }
    }
}
