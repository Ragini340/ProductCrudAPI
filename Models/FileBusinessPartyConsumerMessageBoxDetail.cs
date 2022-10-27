using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileBusinessPartyConsumerMessageBoxDetail
    {
        public int FbpconsumerMessageBoxDetailId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int? BusOrgId { get; set; }
        public int? ContactId { get; set; }
        public int? IsAdhocContactRegister { get; set; }
        public string? ConsumerMessageBoxId { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
    }
}
