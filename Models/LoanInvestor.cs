using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LoanInvestor
    {
        public LoanInvestor()
        {
            Loan1LoanInvestors = new HashSet<Loan1LoanInvestor>();
            LoanInvestorContacts = new HashSet<LoanInvestorContact>();
        }

        public int LoanInvestorId { get; set; }
        public int BusOrgId { get; set; }
        public int LoanInvestorBusOrgId { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? LastActivationDate { get; set; }
        public int? LastActivationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public int? DeactivationUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual BusOrg LoanInvestorBusOrg { get; set; } = null!;
        public virtual ICollection<Loan1LoanInvestor> Loan1LoanInvestors { get; set; }
        public virtual ICollection<LoanInvestorContact> LoanInvestorContacts { get; set; }
    }
}
