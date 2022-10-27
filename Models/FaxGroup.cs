using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaxGroup
    {
        public int FaxGroupId { get; set; }
        public string? FaxGroupName { get; set; }
        public string? Description { get; set; }
        public string? FaxNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailId { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public string? AddrLine3 { get; set; }
        public string? AddrLine4 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual Employee? CreatedByNavigation { get; set; }
    }
}
