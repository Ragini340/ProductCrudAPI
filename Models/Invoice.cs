using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoicePaymentInfos = new HashSet<InvoicePaymentInfo>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            Files = new HashSet<ServiceFile>();
        }

        public int InvoiceId { get; set; }
        public int ClassTypeId { get; set; }
        public int OrderId { get; set; }
        public int? BillToEntityRoleTypeCdId { get; set; }
        public long? InvoiceNum { get; set; }
        public DateTime? InvoiceStatusDate { get; set; }
        public int? InvoicedByEmployeeId { get; set; }
        public int InvoiceStatusCdId { get; set; }
        public DateTime? ExportRequestDate { get; set; }
        public int? ExportInfoId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public int? BillToEntityId { get; set; }
        public short? SpaflagInvoice { get; set; }

        public virtual TypeCdDmt? BillToEntityRoleTypeCd { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ExportInfo? ExportInfo { get; set; }
        public virtual TypeCdDmt InvoiceStatusCd { get; set; } = null!;
        public virtual Employee? InvoicedByEmployee { get; set; }
        public virtual CustomerOrder Order { get; set; } = null!;
        public virtual InvoiceFeesSortOrder? InvoiceFeesSortOrder { get; set; }
        public virtual ICollection<InvoicePaymentInfo> InvoicePaymentInfos { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }

        public virtual ICollection<ServiceFile> Files { get; set; }
    }
}
