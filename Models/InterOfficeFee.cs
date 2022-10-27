using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InterOfficeFee
    {
        public InterOfficeFee()
        {
            InterOfficeFeeStatusHistories = new HashSet<InterOfficeFeeStatusHistory>();
        }

        public int InterOfficeFeeId { get; set; }
        public int FileId { get; set; }
        public int FeeId { get; set; }
        public int GllookupId { get; set; }
        public int StatusCd { get; set; }
        public int? PayeeFileBusinessPartyId { get; set; }
        public decimal FeeAmount { get; set; }
        public int? InterOfficeFeeExtractId { get; set; }
        public int? DocumentNum { get; set; }
        public string? FeeDescr { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public virtual Fee Fee { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Gllookup Gllookup { get; set; } = null!;
        public virtual FileBusinessParty? PayeeFileBusinessParty { get; set; }
        public virtual ICollection<InterOfficeFeeStatusHistory> InterOfficeFeeStatusHistories { get; set; }
    }
}
