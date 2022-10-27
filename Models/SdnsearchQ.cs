using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SdnsearchQ
    {
        public int SdnsearchQid { get; set; }
        public int? SdntrackingId { get; set; }
        public string? Name { get; set; }
        public string? ContactName { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Status { get; set; }
        public string? Server { get; set; }
        public int FileId { get; set; }
        public string? RoleTypeCdId { get; set; }
        public string? UniqueKey { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? EntityTypeId { get; set; }

        public virtual ClassType? EntityType { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Sdntracking? Sdntracking { get; set; }
    }
}
