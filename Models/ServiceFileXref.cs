using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileXref
    {
        public int FileId { get; set; }
        public int OrderTypeCdid { get; set; }
        public DateTime? LocalCloseDueDate { get; set; }
        public string? FileParams { get; set; }
    }
}
