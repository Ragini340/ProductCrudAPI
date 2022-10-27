using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchType
    {
        public SearchType()
        {
            FftsearchTypeXrefs = new HashSet<FftsearchTypeXref>();
            ProgramTypeSearchInstructions = new HashSet<ProgramTypeSearchInstruction>();
            ProgramTypeSearchTypeXrefs = new HashSet<ProgramTypeSearchTypeXref>();
            SearchTypeTypeCdXrefs = new HashSet<SearchTypeTypeCdXref>();
            TemplateFilterSearchTypeXrefDocPreps = new HashSet<TemplateFilterSearchTypeXrefDocPrep>();
            TemplateFilterSearchTypeXrefs = new HashSet<TemplateFilterSearchTypeXref>();
            WorkFlowTemplateSearchTypeXrefs = new HashSet<WorkFlowTemplateSearchTypeXref>();
        }

        public int SearchTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? Descr { get; set; }
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<FftsearchTypeXref> FftsearchTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeSearchInstruction> ProgramTypeSearchInstructions { get; set; }
        public virtual ICollection<ProgramTypeSearchTypeXref> ProgramTypeSearchTypeXrefs { get; set; }
        public virtual ICollection<SearchTypeTypeCdXref> SearchTypeTypeCdXrefs { get; set; }
        public virtual ICollection<TemplateFilterSearchTypeXrefDocPrep> TemplateFilterSearchTypeXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterSearchTypeXref> TemplateFilterSearchTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateSearchTypeXref> WorkFlowTemplateSearchTypeXrefs { get; set; }
    }
}
