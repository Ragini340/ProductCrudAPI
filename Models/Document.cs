using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Document
    {
        public Document()
        {
            CoInsurancePolicyDocXrefs = new HashSet<CoInsurancePolicyDocXref>();
            Docphrases = new HashSet<Docphrase>();
            Principals = new HashSet<Principal>();
        }

        public int DocId { get; set; }
        public int ClassTypeId { get; set; }
        public string Name { get; set; } = null!;
        public int TemplateId { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public short? DraftFlag { get; set; }
        public int FileId { get; set; }
        public int? CommitApprovedChgById { get; set; }
        public DateTime? CommitApprovedChgDate { get; set; }
        public short? CommitApprovedFlag { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CommitDocIdforPolicy { get; set; }
        public int? LoanIdforPolicy { get; set; }
        public long? DeliveryEventLogId { get; set; }
        public short? RemovedFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual DeliveryEventLog? DeliveryEventLog { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Template Template { get; set; } = null!;
        public virtual PolicyUnderwriterXref? PolicyUnderwriterXref { get; set; }
        public virtual ICollection<CoInsurancePolicyDocXref> CoInsurancePolicyDocXrefs { get; set; }
        public virtual ICollection<Docphrase> Docphrases { get; set; }

        public virtual ICollection<Principal> Principals { get; set; }
    }
}
