using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VTextIdFileIdOnDocPhraseDocPhraseElementDirectly
    {
        public long? TextId { get; set; }
        public int FileId { get; set; }
        public string ReferencingTb { get; set; } = null!;
        public string ReferencingTbShort { get; set; } = null!;
        public string FkId { get; set; } = null!;
    }
}
