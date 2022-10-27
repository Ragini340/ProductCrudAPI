using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeSecurityChangeHistory
    {
        public int ChangeId { get; set; }
        public int ChangeEventId { get; set; }
        public int EmployeeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int? RoleId { get; set; }
        public string? TicketNum { get; set; }
        public int UserId { get; set; }
        public DateTime EventDate { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? ProfileId { get; set; }
        public int? SecOfficeGroupId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual TypeCdDmt ChangeEvent { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual Profile? Profile { get; set; }
        public virtual Role? Role { get; set; }
        public virtual SecOfficeGroup? SecOfficeGroup { get; set; }
        public virtual Employee User { get; set; } = null!;
    }
}
