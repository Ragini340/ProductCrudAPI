using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LoanInvestorContact
    {
        public LoanInvestorContact()
        {
            Loan1LoanInvestorContacts = new HashSet<Loan1LoanInvestorContact>();
        }

        public int LoanInvestorContactId { get; set; }
        public int LoanInvestorId { get; set; }
        public int ContactId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual LoanInvestor LoanInvestor { get; set; } = null!;
        public virtual ICollection<Loan1LoanInvestorContact> Loan1LoanInvestorContacts { get; set; }
    }
}
