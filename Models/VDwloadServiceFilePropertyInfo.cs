using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadServiceFilePropertyInfo
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public string? PropertyName { get; set; }
        public int? PropertyTypeObjectCd { get; set; }
        public string? PropertyTypeName { get; set; }
        public string? TaxNum { get; set; }
        public string? SupplementalTaxNum { get; set; }
        public string? MiscTaxNum { get; set; }
        public string? TaxTypeDescr { get; set; }
        public string? TaxYr { get; set; }
        public string? TaxRateAreaNum { get; set; }
        public decimal? TaxExemptionAmt { get; set; }
        public string? TaxExemptionTypeDescr { get; set; }
        public string? Fee { get; set; }
        public long? ShortLegalDescrId { get; set; }
        public long? FullLegalDescrId { get; set; }
        public string? PropertyAddress1 { get; set; }
        public string? PropertyAddress2 { get; set; }
        public string? CityOfProperty { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? Comments { get; set; }
    }
}
