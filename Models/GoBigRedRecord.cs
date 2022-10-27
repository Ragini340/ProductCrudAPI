using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GoBigRedRecord
    {
        public int? RecordTypeId { get; set; }
        public int? RecordId { get; set; }
        public int? NewRecordId { get; set; }
        public string? Error { get; set; }
        public string? Comments { get; set; }
        public bool ContainsCaliforniaCorporation { get; set; }
        public bool ContainsDataElementSeal { get; set; }
        public bool ContainsDataElementUwbfsta { get; set; }
        public bool ContainsUnderSealOfTheCompany { get; set; }
        public bool ContainsSignedAndSealed { get; set; }
        public bool ContainsImage { get; set; }
        public bool InUseByAnActiveTemplateInAgoBigRedRegion { get; set; }
        public bool ManullyExcluded { get; set; }
        public bool HasPotential { get; set; }
    }
}
