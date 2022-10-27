using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TempSsisNcsPostDocumentcopylogdetail
    {
        public int? DocumentCopyLogId { get; set; }
        public long? NgDocId { get; set; }
        public long? LegacyDocId { get; set; }
        public int? CopyStatusId { get; set; }
    }
}
