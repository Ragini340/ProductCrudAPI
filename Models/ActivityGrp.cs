using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ActivityGrp
    {
        public ActivityGrp()
        {
            ActivityGrpActivityXrefs = new HashSet<ActivityGrpActivityXref>();
            RoleChangeHistories = new HashSet<RoleChangeHistory>();
            ScreenActivityActivityGrpXrefs = new HashSet<ScreenActivityActivityGrpXref>();
            SecuredElements = new HashSet<SecuredElement>();
            ServiceOperationSecurityXrefs = new HashSet<ServiceOperationSecurityXref>();
            BusinessUnits = new HashSet<BusinessUnit>();
        }

        public int ActivityGrpId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public string? Descr { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<ActivityGrpActivityXref> ActivityGrpActivityXrefs { get; set; }
        public virtual ICollection<RoleChangeHistory> RoleChangeHistories { get; set; }
        public virtual ICollection<ScreenActivityActivityGrpXref> ScreenActivityActivityGrpXrefs { get; set; }
        public virtual ICollection<SecuredElement> SecuredElements { get; set; }
        public virtual ICollection<ServiceOperationSecurityXref> ServiceOperationSecurityXrefs { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
    }
}
