using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Ibadatum
    {
        public string? Company { get; set; }
        public string? Office { get; set; }
        public int? Buid { get; set; }
        public string? AccountNumber { get; set; }
        public string? ClosingWithdrawal { get; set; }
        public string? AvailableBalance { get; set; }
        public string? InterestPaidYtd { get; set; }
        public string? InterestPaidLastYr { get; set; }
        public string? FileNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? AccountTitleLine1 { get; set; }
        public string? AccountTitleLine2 { get; set; }
        public string? AccountTitleLine3 { get; set; }
        public string? NameAddressLine1 { get; set; }
        public string? NameAddressLine2 { get; set; }
        public string? CityandState { get; set; }
        public string? ZipCode { get; set; }
        public string? TaxId { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string? TypeCode { get; set; }
        public int? FileId { get; set; }
        public decimal? CurrentBalance { get; set; }
        public int IbadataId { get; set; }
    }
}
