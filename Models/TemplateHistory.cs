using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateHistory
    {
        public int TemplateHistoryId { get; set; }
        public int TemplateId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int UserId { get; set; }
        public int StatusCd { get; set; }
        public string? Comments { get; set; }

        public virtual Template Template { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
