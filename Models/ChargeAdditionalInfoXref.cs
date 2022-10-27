using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ChargeAdditionalInfoXref
    {
        public int ChargeAdditionalInfoXrefId { get; set; }
        public int ChargeId { get; set; }
        public int? ChargeEntityTypeId { get; set; }
        public string? EntityFullName { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Charge Charge { get; set; } = null!;
        public virtual TypeCdDmt? ChargeEntityType { get; set; }
    }
}
