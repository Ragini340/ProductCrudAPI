using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileDeliveryInstruction
    {
        public int DeliveryInstructionId { get; set; }
        public int FileId { get; set; }
        public int RoleTypeCdId { get; set; }
        public int? BusOrgId { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int? PrincipalId { get; set; }
        public int? SeqNum { get; set; }
        public int? OpeningPackageCopies { get; set; }
        public int? OpeningPackageDeliveryMethod { get; set; }
        public int? CommitmentCopies { get; set; }
        public int? CommitmentDeliveryMethod { get; set; }
        public int? CcrsCopies { get; set; }
        public int? CcrsDeliveryMethod { get; set; }
        public int? PlottedCopies { get; set; }
        public int? PlottedDeliveryMethod { get; set; }
        public int? ExceptionsCopies { get; set; }
        public int? ExceptionsDeliveryMethod { get; set; }
        public byte[] Updts { get; set; } = null!;
        public short? IsEditable { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public short? ImagedFlag { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual FileBusinessParty? FileBusinessParty { get; set; }
        public virtual Principal? Principal { get; set; }
    }
}
