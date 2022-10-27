using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseMarkerFormVersion
    {
        public PhraseMarkerFormVersion()
        {
            PhraseMarkerCopyInfos = new HashSet<PhraseMarkerCopyInfo>();
        }

        public int PhraseMarkerFormId { get; set; }
        public int VersionNumber { get; set; }
        public string? Comments { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }

        public virtual Employee CreationUser { get; set; } = null!;
        public virtual PhraseMarkerForm PhraseMarkerForm { get; set; } = null!;
        public virtual ICollection<PhraseMarkerCopyInfo> PhraseMarkerCopyInfos { get; set; }
    }
}
