using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AtptextElementMap
    {
        public int AtptextElementMapId { get; set; }
        public int AtpphraseMapId { get; set; }
        public string TextElementName { get; set; } = null!;
        public string Bpmelement { get; set; } = null!;
        public int StatusCd { get; set; }
    }
}
