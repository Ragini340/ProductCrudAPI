using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProcessType
    {
        public ProcessType()
        {
            TaskTemplatePackageSuccessorProcesses = new HashSet<TaskTemplatePackageSuccessorProcess>();
            WorkFlowTemplates = new HashSet<WorkFlowTemplate>();
        }

        public int ProcessTypeId { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public int CategoryTypeCdid { get; set; }
        public int? BusinessunitId { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastActivatedDate { get; set; }
        public DateTime? DeActivatedDate { get; set; }
        public int? StatusChngUserId { get; set; }
        public string? Comments { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ICollection<TaskTemplatePackageSuccessorProcess> TaskTemplatePackageSuccessorProcesses { get; set; }
        public virtual ICollection<WorkFlowTemplate> WorkFlowTemplates { get; set; }
    }
}
