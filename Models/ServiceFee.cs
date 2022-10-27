using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFee
    {
        public int ServiceFeeId { get; set; }
        public int FileId { get; set; }
        public int FeeId { get; set; }
        public int GllookupId { get; set; }
        public int StatusCd { get; set; }
        public int? PayeeFileBusinessPartyId { get; set; }
        public decimal FeeAmount { get; set; }
        public int? ServiceFeeExtractId { get; set; }
        public int? DocumentNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Fee Fee { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Gllookup Gllookup { get; set; } = null!;
        public virtual FileBusinessParty? PayeeFileBusinessParty { get; set; }
    }
}
