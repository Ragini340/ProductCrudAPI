using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseMarkerForm
    {
        public PhraseMarkerForm()
        {
            PhraseMarkerCopyInfos = new HashSet<PhraseMarkerCopyInfo>();
            PhraseMarkerFormVersions = new HashSet<PhraseMarkerFormVersion>();
            PhraseMarkers = new HashSet<PhraseMarker>();
        }

        public int PhraseMarkerFormId { get; set; }
        public int ClassTypeId { get; set; }
        public string FileName { get; set; } = null!;
        public int? InstanceNumber { get; set; }
        public int BusinessUnitId { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public int? CheckedOutById { get; set; }
        public byte[]? Document { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee? CheckedOutBy { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<PhraseMarkerCopyInfo> PhraseMarkerCopyInfos { get; set; }
        public virtual ICollection<PhraseMarkerFormVersion> PhraseMarkerFormVersions { get; set; }
        public virtual ICollection<PhraseMarker> PhraseMarkers { get; set; }
    }
}
