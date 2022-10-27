using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ImagingPurgeRun
    {
        public long FileId { get; set; }
        public DateTime? RunStartDate { get; set; }
        public bool? RunStatus { get; set; }
    }
}
