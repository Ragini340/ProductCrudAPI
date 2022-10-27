using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Trust32Extract
    {
        public Trust32Extract()
        {
            DepositLists = new HashSet<DepositList>();
            Disbursements = new HashSet<Disbursement>();
            Ibatransactions = new HashSet<Ibatransaction>();
        }

        public int ExtractId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string CompanyOfficeNumber { get; set; } = null!;
        public DateTime CutOffDate { get; set; }
        public DateTime ExtractDateTime { get; set; }
        public DateTime? ExtractCompleteDateTime { get; set; }
        public DateTime? TransmissionDateTime { get; set; }
        public byte? TransmissionStatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? ExtractType { get; set; }

        public virtual ICollection<DepositList> DepositLists { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<Ibatransaction> Ibatransactions { get; set; }
    }
}
