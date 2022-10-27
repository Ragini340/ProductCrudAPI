using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateCustomerXref
    {
        public int TaskTemplateCustomerXrefId { get; set; }
        public int TaskTemplateId { get; set; }
        public int TaskTypeCdid { get; set; }
        public string? ResourceString { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? SeqNum { get; set; }

        public virtual TaskTemplate TaskTemplate { get; set; } = null!;
        public virtual TypeCdDmt TaskTypeCd { get; set; } = null!;
    }
}
