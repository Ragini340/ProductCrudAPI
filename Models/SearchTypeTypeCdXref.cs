using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchTypeTypeCdXref
    {
        public int? TypeCdId { get; set; }
        public int? SearchTypeId { get; set; }
        public int SearchTypeTypeCdXrefId { get; set; }

        public virtual SearchType? SearchType { get; set; }
        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
