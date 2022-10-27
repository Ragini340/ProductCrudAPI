using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProcessedInterfaceTask
    {
        public int TaskId { get; set; }
        public DateTime? ProcessedDate { get; set; }
    }
}
