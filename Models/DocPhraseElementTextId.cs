using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocPhraseElementTextId
    {
        public int DocPhraseElementId { get; set; }
        public int? ValueTextId { get; set; }
        public int? NewValueTextId { get; set; }
        public int DocPhraseElementTextIdsId { get; set; }
    }
}
