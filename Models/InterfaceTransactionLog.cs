using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterfaceTransactionLog
    {
        public int InterfaceTransactionLogId { get; set; }
        public int InterfaceTransactionId { get; set; }
        public byte? TransactionTypeId { get; set; }
        public byte? StatusCd { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? Comments { get; set; }

        public virtual InterfaceTransaction InterfaceTransaction { get; set; } = null!;
    }
}
