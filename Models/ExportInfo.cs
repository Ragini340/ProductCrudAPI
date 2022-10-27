using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ExportInfo
    {
        public ExportInfo()
        {
            Disbursements = new HashSet<Disbursement>();
            Invoices = new HashSet<Invoice>();
        }

        public int ExportInfoId { get; set; }
        public int ClassTypeId { get; set; }
        public DateTime? ExportStartDate { get; set; }
        public DateTime? ExportEndDate { get; set; }
        public int StatusCd { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? ApplId { get; set; }

        public virtual Application? Appl { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
