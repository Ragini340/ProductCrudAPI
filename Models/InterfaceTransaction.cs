using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterfaceTransaction
    {
        public InterfaceTransaction()
        {
            InterfaceTransactionLogs = new HashSet<InterfaceTransactionLog>();
        }

        public int InterfaceTransactionId { get; set; }
        public int? InterfaceAppTypeCd { get; set; }
        public int? FileId { get; set; }
        public string? TransactionId { get; set; }
        public string? TitleServiceOrderId { get; set; }
        public string? EscrowServiceOrderId { get; set; }
        public string? SubEscrowServiceOrderId { get; set; }
        public byte? StatusCd { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<InterfaceTransactionLog> InterfaceTransactionLogs { get; set; }
    }
}
