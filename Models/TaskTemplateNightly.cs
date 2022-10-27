using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateNightly
    {
        public int TaskTemplateId { get; set; }
        public byte? Ucflag { get; set; }
        public byte? IsPrivate { get; set; }
        public string? FriendlyName { get; set; }
        public int? TaskTemplateCustomerXrefId { get; set; }
        public int? TaskTypeCdid { get; set; }
        public string? ResourceString { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdDate { get; set; }
    }
}
