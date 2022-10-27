using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileDetailsForScheduler
    {
        public int FileDetailsForSchedulerId { get; set; }
        public int? FileId { get; set; }
        public int? TitleEscrowInfoId { get; set; }
        public int? PropertyId { get; set; }
        public int? BusOrgId { get; set; }
        public int? PrincipalId { get; set; }
        public int? PartyType { get; set; }
        public int? PartySeqNum { get; set; }
        public int? AddrBookEntryId { get; set; }
        public int? PhysicalAddrId { get; set; }
        public int? StatusCd { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
