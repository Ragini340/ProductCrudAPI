using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocElementInfoTrack
    {
        public int DocElementInfoTrackId { get; set; }
        public int FileId { get; set; }
        public long DocumentId { get; set; }
        public long DocPhraseId { get; set; }
        public int? PhraseId { get; set; }
        public long DocPhraseElementId { get; set; }
        public int? PhraseElementId { get; set; }
        public int? UserId { get; set; }
        public string? OldTextData { get; set; }
        public string? NewTextData { get; set; }
        public bool IsRefreshed { get; set; }
        public DateTime ModificationDate { get; set; }
        public string? PhraseObjectCode { get; set; }
        public string? DeobjectCode { get; set; }
    }
}
