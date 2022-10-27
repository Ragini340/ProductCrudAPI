using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Loan1LoanInvestor
    {
        public Loan1LoanInvestor()
        {
            Loan1LoanInvestorContacts = new HashSet<Loan1LoanInvestorContact>();
        }

        public int Loan1LoanInvestorId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int LoanInvestorId { get; set; }
        public int SeqNum { get; set; }
        public string? LoanNumber { get; set; }
        public DateTime? TransferDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual LoanInvestor LoanInvestor { get; set; } = null!;
        public virtual ICollection<Loan1LoanInvestorContact> Loan1LoanInvestorContacts { get; set; }
    }
}
