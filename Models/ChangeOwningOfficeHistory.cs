using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ChangeOwningOfficeHistory
    {
        public int ChangeOwningOfficeHistoryId { get; set; }
        public int FileId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int ChangeTypeCdId { get; set; }
        public int EmployeeId { get; set; }
        public int OldOwnerOfficeId { get; set; }
        public int? NewOwnerOfficeId { get; set; }
        public int? ExtractId { get; set; }

        public virtual TypeCdDmt ChangeTypeCd { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual BusinessUnit? NewOwnerOffice { get; set; }
        public virtual BusinessUnit OldOwnerOffice { get; set; } = null!;
    }
}
