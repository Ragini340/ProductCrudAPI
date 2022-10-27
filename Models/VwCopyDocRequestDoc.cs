using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwCopyDocRequestDoc
    {
        public int CopyDocsRequestId { get; set; }
        public int SourceFileId { get; set; }
        public int? StatusCd { get; set; }
        public int? DocId { get; set; }
    }
}
