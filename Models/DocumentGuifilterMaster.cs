using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentGuifilterMaster
    {
        public DocumentGuifilterMaster()
        {
            DocumentGridFileAndScreenGridFilters = new HashSet<DocumentGridFileAndScreenGridFilter>();
        }

        public int DocumentGuifilterMasterId { get; set; }
        public string FilterName { get; set; } = null!;
        public int? SuperDocumentGuifilterMasterId { get; set; }
        public string? FilterNumber { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? DocTypeCdid { get; set; }

        public virtual ICollection<DocumentGridFileAndScreenGridFilter> DocumentGridFileAndScreenGridFilters { get; set; }
    }
}
