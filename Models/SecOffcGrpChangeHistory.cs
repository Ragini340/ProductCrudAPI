using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SecOffcGrpChangeHistory
    {
        public int ChangeId { get; set; }
        public int ChangeEventId { get; set; }
        public int SecOfficeGroupId { get; set; }
        public int? BusinessUnitId { get; set; }
        public string? TicketNum { get; set; }
        public int UserId { get; set; }
        public DateTime EventDate { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual TypeCdDmt ChangeEvent { get; set; } = null!;
        public virtual SecOfficeGroup SecOfficeGroup { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
