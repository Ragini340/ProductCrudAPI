using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Sdntracking
    {
        public Sdntracking()
        {
            SdnsearchQs = new HashSet<SdnsearchQ>();
            SdnsearchRoleTypes = new HashSet<SdnsearchRoleType>();
        }

        public int SdntrackingId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public short? SearchedFlag { get; set; }
        public DateTime? SearchedDate { get; set; }
        public DateTime? HitDate { get; set; }
        public DateTime? DocUpldClearedDate { get; set; }
        public DateTime? DocUpldNotClearedDate { get; set; }
        public DateTime? ProcessCompletedDate { get; set; }
        public DateTime? NoHitDate { get; set; }
        public short? EmailNotificationFlag { get; set; }
        public string? EmailReceipientName { get; set; }
        public short HitFlag { get; set; }
        public short? DocUpldClearedFlag { get; set; }
        public short? ProcessCompletedFlag { get; set; }
        public int FileId { get; set; }
        public int? OriginalSdntrackingId { get; set; }
        public int? SearchCount { get; set; }
        public string? ContactName { get; set; }
        public int? EntityId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? EntityTypeId { get; set; }

        public virtual ClassType? EntityType { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual ICollection<SdnsearchQ> SdnsearchQs { get; set; }
        public virtual ICollection<SdnsearchRoleType> SdnsearchRoleTypes { get; set; }
    }
}
