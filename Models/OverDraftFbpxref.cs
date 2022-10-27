using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverDraftFbpxref
    {
        public int OverDraftFbpxrefId { get; set; }
        public int OverDraftId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int FileId { get; set; }
        public DateTime CreateDate { get; set; }
        public string? FileBusinessPartyName { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual OverDraftMaster OverDraft { get; set; } = null!;
    }
}
