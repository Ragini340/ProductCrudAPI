using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IncomingWireXpresswireUserIdxref
    {
        public short RecId { get; set; }
        public int? BankUserRepId { get; set; }
        public string? XpressWireUserId { get; set; }
        public int? SuperBusinessUnitId { get; set; }
    }
}
