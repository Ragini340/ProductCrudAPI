using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ScreenList
    {
        public ScreenList()
        {
            DocumentGridFileAndScreenGridFilters = new HashSet<DocumentGridFileAndScreenGridFilter>();
            FastSceenGridScreenListXrefs = new HashSet<FastSceenGridScreenListXref>();
            ScreenActivityActivityGrpXrefs = new HashSet<ScreenActivityActivityGrpXref>();
            SecuredElements = new HashSet<SecuredElement>();
        }

        public int ScreenId { get; set; }
        public string? ObjectCd { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public int? Parent { get; set; }
        public byte? HasChild { get; set; }
        public int? SeqNum { get; set; }
        public byte? IsFileAdm { get; set; }
        public string? CssClass { get; set; }
        public string? ToolTip { get; set; }
        public byte? IsShortCut { get; set; }
        public byte? LinkAviliableByFileStatus { get; set; }
        public byte? AccessLevel { get; set; }
        public byte? IsExchange { get; set; }

        public virtual ICollection<DocumentGridFileAndScreenGridFilter> DocumentGridFileAndScreenGridFilters { get; set; }
        public virtual ICollection<FastSceenGridScreenListXref> FastSceenGridScreenListXrefs { get; set; }
        public virtual ICollection<ScreenActivityActivityGrpXref> ScreenActivityActivityGrpXrefs { get; set; }
        public virtual ICollection<SecuredElement> SecuredElements { get; set; }
    }
}
