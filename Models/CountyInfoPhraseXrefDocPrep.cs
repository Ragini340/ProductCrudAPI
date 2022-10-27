using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CountyInfoPhraseXrefDocPrep
    {
        public int CountyInfoId { get; set; }
        public int PhraseId { get; set; }

        public virtual CountyInfo CountyInfo { get; set; } = null!;
    }
}
