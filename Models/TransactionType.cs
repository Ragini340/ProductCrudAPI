using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            ServiceFileFees = new HashSet<ServiceFileFee>();
        }

        public int TransactionTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string Descr { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
    }
}
