using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BankAccountAuthentication
    {
        public BankAccountAuthentication()
        {
            WireInstructionValidations = new HashSet<WireInstructionValidation>();
        }

        public int BankAccountAuthenticationId { get; set; }
        public int FileId { get; set; }
        public short RequestTypeCdId { get; set; }
        public string AgencyName { get; set; } = null!;
        public string AccountNum { get; set; } = null!;
        public string FormattedAcctNum { get; set; } = null!;
        public string AccountNumHmac { get; set; } = null!;
        public string RoutingNumber { get; set; } = null!;
        public string? Payee { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BusinessName { get; set; }
        public byte PayeeType { get; set; }
        public byte StatusCd { get; set; }
        public byte? SafeValidationResult { get; set; }
        public string? ValidationMessage { get; set; }
        public string? RecommendedAction { get; set; }
        public string? Resultcode { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public string? ResponseData { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Address { get; set; }
        public string? RequestData { get; set; }

        public virtual FastresultCodeXref? ResultcodeNavigation { get; set; }
        public virtual ICollection<WireInstructionValidation> WireInstructionValidations { get; set; }
    }
}
