using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SigningLoan
    {
        public int LoanId { get; set; }
        public int SigningId { get; set; }
        public int LenderId { get; set; }
        public string LoanNum { get; set; } = null!;
        public decimal? LoanAmt { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg Lender { get; set; } = null!;
        public virtual Signing Signing { get; set; } = null!;
    }
}
