using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GabentryRequestQueue
    {
        public GabentryRequestQueue()
        {
            GabqueueContactHistories = new HashSet<GabqueueContactHistory>();
        }

        public int GabentryRequestQueueId { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;
        public int? FileId { get; set; }
        public string? FileNum { get; set; }
        public int RoleTypeCdId { get; set; }
        public string? RoleTypeName { get; set; }
        public int? BusOrgId { get; set; }
        public string? BusOrgIdcode { get; set; }
        public int? ReferenceBusOrgId { get; set; }
        public int? DuplicateBusOrgId { get; set; }
        public string Name { get; set; } = null!;
        public int RequestorId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public int? LockedByUserId { get; set; }
        public string? LockedByUserName { get; set; }
        public int? StatusId { get; set; }
        public string? Status { get; set; }
        public string? EntryInstructions { get; set; }
        public string? Comments { get; set; }
        public int? RequestTypeCdId { get; set; }
        public byte[]? UpdTs { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public long? EnterpriseId { get; set; }
        public string? EnterpriseNumber { get; set; }
        public int? MdmstatusCd { get; set; }
        public bool? IslegacyRequest { get; set; }
        public long? ProcessedDataTextId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusOrg? DuplicateBusOrg { get; set; }
        public virtual ServiceFile? File { get; set; }
        public virtual Employee? LockedByUser { get; set; }
        public virtual BusOrg? ReferenceBusOrg { get; set; }
        public virtual BusinessUnit Region { get; set; } = null!;
        public virtual TypeCdDmt? RequestTypeCd { get; set; }
        public virtual Employee Requestor { get; set; } = null!;
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
        public virtual ICollection<GabqueueContactHistory> GabqueueContactHistories { get; set; }
    }
}
