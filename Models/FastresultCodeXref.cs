using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FastresultCodeXref
    {
        public FastresultCodeXref()
        {
            BankAccountAuthentications = new HashSet<BankAccountAuthentication>();
            PayeeIdentifications = new HashSet<PayeeIdentification>();
        }

        public int FastresultCodeXrefId { get; set; }
        public string? Result { get; set; }
        public string Resultcode { get; set; } = null!;
        public string? ResponseData { get; set; }
        public string? RecommendedAction { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<BankAccountAuthentication> BankAccountAuthentications { get; set; }
        public virtual ICollection<PayeeIdentification> PayeeIdentifications { get; set; }
    }
}
