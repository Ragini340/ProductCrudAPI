using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentMap
    {
        public int LegacyDocId { get; set; }
        public long NextGenDocId { get; set; }
        public int? CommitDocIdforPolicy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public short StatusCd { get; set; }
        public byte? DraftFlag { get; set; }
        public long? FileId { get; set; }
    }
}
