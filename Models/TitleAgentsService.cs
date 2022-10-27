using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TitleAgentsService
    {
        public int TitleAgentsServiceId { get; set; }
        public int? FileId { get; set; }
        public int? ServiceTypeCdid { get; set; }

        public virtual ServiceFile? File { get; set; }
    }
}
