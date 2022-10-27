using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CopyPhraseRequest
    {
        public int CopyPhraseRequestId { get; set; }
        public int CopyDocsRequestId { get; set; }
        public int TargetFileId { get; set; }
        public int SourceFileId { get; set; }
        public int StatusCd { get; set; }
        public DateTime RequestedTime { get; set; }
        public int TargetDocId { get; set; }
        public int SourceDocId { get; set; }
        public string? SourceDocPhrases { get; set; }

        public virtual CopyDocsRequest CopyDocsRequest { get; set; } = null!;
    }
}
