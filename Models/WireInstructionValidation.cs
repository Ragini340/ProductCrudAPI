using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WireInstructionValidation
    {
        public int WireAuthPayeeXrefId { get; set; }
        public int FileId { get; set; }
        public int WireDisbursementDetailId { get; set; }
        public int? BankAccountAuthenticationId { get; set; }
        public int? PayeeIdentificationId { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public long? AccountingPrivacyEventLogId { get; set; }

        public virtual BankAccountAuthentication? BankAccountAuthentication { get; set; }
        public virtual PayeeIdentification? PayeeIdentification { get; set; }
        public virtual WireDisbursementDetail WireDisbursementDetail { get; set; } = null!;
    }
}
