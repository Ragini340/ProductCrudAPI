using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileEntry
    {
        public int FileEntryId { get; set; }
        public int ClassTypeId { get; set; }
        public int AccountId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? TransactionId { get; set; }
        public int? CreditFlag { get; set; }
        public decimal Amount { get; set; }
        public int? RefNum { get; set; }
        public int? TasupdateFlag { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual FileAccount Account { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? TransactionTypeCd { get; set; }
    }
}
