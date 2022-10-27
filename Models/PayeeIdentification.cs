using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PayeeIdentification
    {
        public PayeeIdentification()
        {
            WireInstructionValidations = new HashSet<WireInstructionValidation>();
        }

        public int PayeeIdentificationId { get; set; }
        public string AgencyName { get; set; } = null!;
        public string Payee { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BusinessName { get; set; }
        public byte PayeeType { get; set; }
        public string Address1 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string HomePhone { get; set; } = null!;
        public string CellPhone { get; set; } = null!;
        public byte? SafeValidationResult { get; set; }
        public string? ValidationMessage { get; set; }
        public string? RecommendedAction { get; set; }
        public string? Resultcode { get; set; }
        public DateTime RequestDateTime { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? RequestData { get; set; }

        public virtual FastresultCodeXref? ResultcodeNavigation { get; set; }
        public virtual ICollection<WireInstructionValidation> WireInstructionValidations { get; set; }
    }
}
