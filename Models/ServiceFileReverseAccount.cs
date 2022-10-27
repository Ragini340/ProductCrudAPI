using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileReverseAccount
    {
        public int ServiceFileReverseAccountId { get; set; }
        public int? FileId { get; set; }
        public int? BankAcctId { get; set; }
        public string? ReverseAccountNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? ReverseFormattedAccountNum { get; set; }

        public virtual BankAccount? BankAcct { get; set; }
        public virtual ServiceFile? File { get; set; }
    }
}
