using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Loan1LoanInvestorContact
    {
        public int Loan1LoanInvestorContactId { get; set; }
        public int Loan1LoanInvestorId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int LoanInvestorContactId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual Loan1LoanInvestor Loan1LoanInvestor { get; set; } = null!;
        public virtual LoanInvestorContact LoanInvestorContact { get; set; } = null!;
    }
}
