using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AtpphraseMap
    {
        public int AtpphraseMapId { get; set; }
        public string? DocType { get; set; }
        public string? DocSubType { get; set; }
        public string PhraseCd { get; set; } = null!;
        public int StatusCd { get; set; }
    }
}
