using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CorpCpuproductionOffice
    {
        public int CpuproductionOfficeId { get; set; }
        public int? DeliveryMethodTypeCdId { get; set; }
        public string? DeliveryAddress { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }

        public virtual BusinessUnit CpuproductionOffice { get; set; } = null!;
        public virtual Employee? CreatedUser { get; set; }
        public virtual TypeCdDmt? DeliveryMethodTypeCd { get; set; }
        public virtual Employee? ModifiedUser { get; set; }
    }
}
