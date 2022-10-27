using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContactRelationship
    {
        public BusOrgContactRelationship()
        {
            BusOrgContactRelationshipChangeHistories = new HashSet<BusOrgContactRelationshipChangeHistory>();
            BusOrgContactRoleRelationshipXrefs = new HashSet<BusOrgContactRoleRelationshipXref>();
        }

        public int BusOrgContactRelationshipId { get; set; }
        public int? ParentContactId { get; set; }
        public int? BusOrgId { get; set; }
        public int? ContactId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? CreationUserId { get; set; }
        public DateTime? LastActivationDate { get; set; }
        public int? LastActivationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public int? DeactivationUserId { get; set; }
        public string? StatusChgComments { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusOrgContact? Contact { get; set; }
        public virtual BusOrgContact? ParentContact { get; set; }
        public virtual Person? Person { get; set; }
        public virtual ICollection<BusOrgContactRelationshipChangeHistory> BusOrgContactRelationshipChangeHistories { get; set; }
        public virtual ICollection<BusOrgContactRoleRelationshipXref> BusOrgContactRoleRelationshipXrefs { get; set; }
    }
}
