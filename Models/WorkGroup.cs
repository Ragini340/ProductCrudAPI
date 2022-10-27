using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkGroup
    {
        public WorkGroup()
        {
            EmployeeWorkgroupXrefs = new HashSet<EmployeeWorkgroupXref>();
            Regions = new HashSet<BusinessUnit>();
            TaskTemplates = new HashSet<TaskTemplate>();
        }

        public int WorkgroupId { get; set; }
        public string? Name { get; set; }
        public int StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[]? Updts { get; set; }

        public virtual Employee? CreationUser { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual ICollection<EmployeeWorkgroupXref> EmployeeWorkgroupXrefs { get; set; }

        public virtual ICollection<BusinessUnit> Regions { get; set; }
        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
    }
}
