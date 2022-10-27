using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessSourceType
    {
        public BusinessSourceType()
        {
            ServiceFiles = new HashSet<ServiceFile>();
        }

        public int BusinessSourceTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string BusinessSourceTypeName { get; set; } = null!;
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
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
    }
}
