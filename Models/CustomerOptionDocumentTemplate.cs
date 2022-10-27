using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CustomerOptionDocumentTemplate
    {
        public int CustomerOptionDocumentTemplateId { get; set; }
        public int BusOrgCustomerOptionId { get; set; }
        public int? TemplateId { get; set; }
        public int? WorkQueueTriggerId { get; set; }
        public int CustomerOptionDocTypeCdId { get; set; }
        public int? StatusCdId { get; set; }
        public short? SeqNum { get; set; }
        public short? Required { get; set; }
        public short? AutoCreate { get; set; }

        public virtual BusOrgCustomerOption BusOrgCustomerOption { get; set; } = null!;
        public virtual TypeCdDmt CustomerOptionDocTypeCd { get; set; } = null!;
        public virtual TypeCdDmt? StatusCd { get; set; }
        public virtual WorkQueueTrigger? WorkQueueTrigger { get; set; }
    }
}
