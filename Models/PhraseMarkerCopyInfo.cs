using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseMarkerCopyInfo
    {
        public int PhraseMarkerTo { get; set; }
        public int? FormTo { get; set; }
        public int? FormFrom { get; set; }
        public int? FormFromLatestVerWhenCopied { get; set; }
        public int PhraseMarkerFrom { get; set; }

        public virtual PhraseMarkerFormVersion? FormFromNavigation { get; set; }
        public virtual PhraseMarkerForm? FormToNavigation { get; set; }
    }
}
