using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwCopyDocInsertPhraseRequest
    {
        public int CopyDocsRequestId { get; set; }
        public int SourceFileId { get; set; }
        public int StatusCd { get; set; }
        public int? PhraseId { get; set; }
        public int DocId { get; set; }
        public long DocPhraseId { get; set; }
    }
}
