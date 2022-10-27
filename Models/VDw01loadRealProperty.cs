using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadRealProperty
    {
        public int PropertyId { get; set; }
        public string? PropertyTypeDescr { get; set; }
        public short StaticSeqNum { get; set; }
        public string? Name { get; set; }
        public string? Township { get; set; }
        public string? Range { get; set; }
        public string? Section { get; set; }
        public string? GovernmentLotNum { get; set; }
        public string? TractNum { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Lot { get; set; }
        public string? Block { get; set; }
        public string? Phase { get; set; }
        public string? Borough { get; set; }
        public string? Province { get; set; }
        public string? MapNum { get; set; }
        public DateTime? MapDate { get; set; }
        public string? Unit { get; set; }
        public string? SubdivisionName { get; set; }
        public string? Parish { get; set; }
        public string? Building { get; set; }
        public string? Parcel { get; set; }
        public long? ShortLegalDescrId { get; set; }
        public long? FullLegalDescrId { get; set; }
        public string? AddtlSectionalDetail { get; set; }
        public string? SubtractName { get; set; }
        public string? Comments { get; set; }
        public string? Condominium { get; set; }
        public string? Fee { get; set; }
    }
}
