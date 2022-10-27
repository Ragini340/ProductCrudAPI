using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RecordDocument
    {
        public RecordDocument()
        {
            LoanInfos = new HashSet<LoanInfo>();
        }

        public int RecordDocId { get; set; }
        public int ClassTypeId { get; set; }
        public int? AddrBookEntryId { get; set; }
        public int? BusOrgId { get; set; }
        public string? InstrumentNumber { get; set; }
        public long? TrustorId { get; set; }
        public DateTime? TrustDeedDate { get; set; }
        public DateTime? RecordedDate { get; set; }
        public string? RecordedBook { get; set; }
        public string? RecordedBookPageNum { get; set; }
        public string? AssigneeBeneficiaryName { get; set; }
        public string? OrigBeneficiaryName { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual BusOrg? BusOrg { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<LoanInfo> LoanInfos { get; set; }
    }
}
