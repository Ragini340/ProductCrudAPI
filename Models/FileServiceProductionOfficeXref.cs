using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileServiceProductionOfficeXref
    {
        public int ProductionOfficeId { get; set; }
        public int FileServiceId { get; set; }
        public int? SeqNum { get; set; }
        public int? OfficerId { get; set; }
        public int? AssistantId { get; set; }

        public virtual Employee? Assistant { get; set; }
        public virtual FileService FileService { get; set; } = null!;
        public virtual Employee? Officer { get; set; }
        public virtual BusinessUnit ProductionOffice { get; set; } = null!;
    }
}
