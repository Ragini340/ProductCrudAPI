using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgCustomerOption
    {
        public BusOrgCustomerOption()
        {
            CustomerOptionDocumentTemplates = new HashSet<CustomerOptionDocumentTemplate>();
        }

        public int BusOrgCustomerOptionId { get; set; }
        public string? PackageName { get; set; }
        public short FassnotaryIntegrate { get; set; }
        public short ClientWebIntegrate { get; set; }
        public int? ClientWebCdId { get; set; }
        public short AttachmentType { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationUserId { get; set; }

        public virtual ICollection<CustomerOptionDocumentTemplate> CustomerOptionDocumentTemplates { get; set; }
    }
}
