using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployedBy
    {
        public EmployedBy()
        {
            Principals = new HashSet<Principal>();
        }

        public int EmployedById { get; set; }
        public int BusinessUnitId { get; set; }
        public string EmployedByName { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int StatusCd { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual Employee? StatusChgUser { get; set; }
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
    }
}
