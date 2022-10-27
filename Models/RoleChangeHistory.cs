using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RoleChangeHistory
    {
        public int ChangeId { get; set; }
        public int ChangeEventId { get; set; }
        public int RoleId { get; set; }
        public int? ActivityGrpId { get; set; }
        public int? ActivityId { get; set; }
        public string? TicketNum { get; set; }
        public int UserId { get; set; }
        public DateTime EventDate { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Activity? Activity { get; set; }
        public virtual ActivityGrp? ActivityGrp { get; set; }
        public virtual TypeCdDmt ChangeEvent { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
