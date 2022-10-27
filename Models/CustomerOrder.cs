using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            Invoices = new HashSet<Invoice>();
            ServiceFiles = new HashSet<ServiceFile>();
            Signings = new HashSet<Signing>();
        }

        public int OrderId { get; set; }
        public int ClassTypeId { get; set; }
        public int? StatusCd { get; set; }
        public int SourceApplId { get; set; }
        public string? SourceApplQueueName { get; set; }
        public string? RefNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? OrderOriginatorId { get; set; }
        public string? ReverseEntity { get; set; }
        public string? RelatedTransaction { get; set; }
        public int? SecondSourceApplId { get; set; }
        public string? SecondSourceApplQueueName { get; set; }
        public int? SecondOrderOriginatorId { get; set; }
        public string? FirstSourceBusinessPartyName { get; set; }
        public string? SecondSourceBusinessPartyName { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Application? OrderOriginator { get; set; }
        public virtual Application? SecondSourceAppl { get; set; }
        public virtual Application SourceAppl { get; set; } = null!;
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
        public virtual ICollection<Signing> Signings { get; set; }
    }
}
