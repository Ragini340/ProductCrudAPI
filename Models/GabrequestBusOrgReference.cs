using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GabrequestBusOrgReference
    {
        public GabrequestBusOrgReference()
        {
            FileBusinessParties = new HashSet<FileBusinessParty>();
        }

        public int GabrequestBusOrgReferenceId { get; set; }
        public int BusOrgId { get; set; }
        public int? ReferenceBusOrgId { get; set; }
        public int? AddrBookEntryId { get; set; }
        public int? ReferenceAddrBookEntryId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public long EnterpriseId { get; set; }
        public int? StatusCd { get; set; }
        public string? Email { get; set; }
        public string? EmployeeName { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
    }
}
