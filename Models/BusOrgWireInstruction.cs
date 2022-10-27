using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgWireInstruction
    {
        public BusOrgWireInstruction()
        {
            BusOrgs = new HashSet<BusOrg>();
            People = new HashSet<Person>();
        }

        public int WireInstId { get; set; }
        public string? BankName { get; set; }
        public string? BankAddr { get; set; }
        public string? Abanum { get; set; }
        public string? AcctNum { get; set; }
        public string? BranchTransitNum { get; set; }
        public string? Ficode { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? DataGovernanceCertifiedFlag { get; set; }
        public int? DataGovernedByUserId { get; set; }
        public DateTime? DataGovernedOn { get; set; }
        public string? TechExcelNum { get; set; }
        public int? AccountType { get; set; }
        public int? BeneficiaryAccount { get; set; }

        public virtual ICollection<BusOrg> BusOrgs { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
