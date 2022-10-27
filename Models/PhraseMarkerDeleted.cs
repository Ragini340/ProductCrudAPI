using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseMarkerDeleted
    {
        public int PhraseMarkerId { get; set; }
        public int ClassTypeId { get; set; }
        public string? Comments { get; set; }
        public short? PageBreakFlag { get; set; }
        public int? OutlineFirst { get; set; }
        public int? PhraseMarkerFormId { get; set; }
        public int FileId { get; set; }
    }
}
