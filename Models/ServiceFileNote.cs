using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileNote
    {
        public ServiceFileNote()
        {
            DisbursementTrackInfos = new HashSet<DisbursementTrackInfo>();
            ServiceFileNoteComments = new HashSet<ServiceFileNoteComment>();
        }

        public int ServiceFileNoteId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int ServiceFileNoteTypeCdId { get; set; }
        public long? NoteId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt ServiceFileNoteTypeCd { get; set; } = null!;
        public virtual TextDatum? TextDatum { get; set; }
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual ICollection<DisbursementTrackInfo> DisbursementTrackInfos { get; set; }
        public virtual ICollection<ServiceFileNoteComment> ServiceFileNoteComments { get; set; }
    }
}
