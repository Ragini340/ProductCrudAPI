using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CopyDocsRequest
    {
        public CopyDocsRequest()
        {
            CopyPhraseRequests = new HashSet<CopyPhraseRequest>();
        }

        public int CopyDocsRequestId { get; set; }
        public int SourceFileId { get; set; }
        public int TargetFileId { get; set; }
        public string DocLine { get; set; } = null!;
        public string? SourceFileNum { get; set; }
        public string? TargetFileNum { get; set; }
        public int? StatusCd { get; set; }
        public DateTime? RequestedTime { get; set; }
        public int? DocTypeCdId { get; set; }

        public virtual TypeCdDmt? DocTypeCd { get; set; }
        public virtual ServiceFile SourceFile { get; set; } = null!;
        public virtual ServiceFile TargetFile { get; set; } = null!;
        public virtual ICollection<CopyPhraseRequest> CopyPhraseRequests { get; set; }
    }
}
