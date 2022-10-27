using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskCategory
    {
        public TaskCategory()
        {
            TaskTemplates = new HashSet<TaskTemplate>();
        }

        public int TaskCategoryId { get; set; }
        public int BusinessUnitId { get; set; }
        public string? CategoryName { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? SeqNum { get; set; }
        public short? InactiveFlag { get; set; }
        public int? SuperTaskCategoryId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee? CreationEmployee { get; set; }
        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
    }
}
