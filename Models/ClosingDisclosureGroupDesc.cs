using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClosingDisclosureGroupDesc
    {
        public int ClosingDisclosureGroupDescId { get; set; }
        public string? GroupDescr { get; set; }
        public int? ChargeProcessTypeCdId { get; set; }
        public int? ChargeCategoryTypeCdId { get; set; }
        public string? SectionType { get; set; }
        public short? FileProcessSeqNum { get; set; }
        public int? FileId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public short IsEditable { get; set; }
        public short IsExpanded { get; set; }
        public int? ResequenceNumber { get; set; }
        public int? IsIndividual { get; set; }

        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
