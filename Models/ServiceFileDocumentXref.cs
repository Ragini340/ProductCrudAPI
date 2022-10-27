using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileDocumentXref
    {
        public ServiceFileDocumentXref()
        {
            CoInsurancePolicyDocXrefDocPreps = new HashSet<CoInsurancePolicyDocXrefDocPrep>();
            PhysicalAddrs = new HashSet<PhysicalAddr>();
        }

        public int FileId { get; set; }
        public long DocId { get; set; }
        public int? CommitDocIdforPolicy { get; set; }
        public int? LoanIdforPolicy { get; set; }
        public int? CommitApprovedChgById { get; set; }
        public DateTime? CommitApprovedChgDate { get; set; }
        public short? CommitApprovedFlag { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public long? DeliveryEventLogId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TemplateId { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Name { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusCd { get; set; }
        public short? RemovedFlag { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual PolicyUnderWriterXrefDocprep? PolicyUnderWriterXrefDocprep { get; set; }
        public virtual ICollection<CoInsurancePolicyDocXrefDocPrep> CoInsurancePolicyDocXrefDocPreps { get; set; }

        public virtual ICollection<PhysicalAddr> PhysicalAddrs { get; set; }
    }
}
