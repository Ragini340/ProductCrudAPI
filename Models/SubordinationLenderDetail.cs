using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SubordinationLenderDetail
    {
        public int SubordinationLenderDetailId { get; set; }
        public int? SubOrdinateTypeCdId { get; set; }
        public int? SubOrdinateId { get; set; }
        public short? Position { get; set; }
        public string? ResponsibleParty { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public DateTime? SubOrdinationOrderDate { get; set; }
        public DateTime? SubRecordedDate { get; set; }
        public string? LoanNumber { get; set; }
        public decimal? LoanAmount { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Instrument { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public DateTime? AssignmentDate { get; set; }

        public virtual FileBusinessParty? FileBusinessParty { get; set; }
        public virtual Subordination? SubOrdinate { get; set; }
        public virtual TypeCdDmt? SubOrdinateTypeCd { get; set; }
    }
}
