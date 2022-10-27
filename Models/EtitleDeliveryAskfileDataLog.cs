using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EtitleDeliveryAskfileDataLog
    {
        public string? LoanNbr { get; set; }
        public string? Relsnbr { get; set; }
        public DateTime? FundedDate { get; set; }
        public double? LoanAmount { get; set; }
        public string? BorrowerFirstName { get; set; }
        public string? BorrowerLastName { get; set; }
        public string? PropAddress { get; set; }
        public string? PropCity { get; set; }
        public string? PropState { get; set; }
        public string? PropZip { get; set; }
        public string? StlmtCoMasterName { get; set; }
        public string? StlmtCoName { get; set; }
        public string? StlmtCoContact { get; set; }
        public string? StlmtCoAddrLine1 { get; set; }
        public string? StlmtCoCity { get; set; }
        public string? StlmtCoStateAbrvCode { get; set; }
        public double? StlmtCoZipCode { get; set; }
        public string? MissingDoc { get; set; }
        public string? NoRind { get; set; }
        public double? ClientNbr { get; set; }
        public int? FileId { get; set; }
        public string? FileNum { get; set; }
        public int? BusinessUnitId { get; set; }
        public string? RegionName { get; set; }
        public string? MatchedComments { get; set; }
        public int? IsModified { get; set; }
        public int? IsEtitleDelivered { get; set; }
        public DateTime? CapturedDate { get; set; }
        public string? AskfileName { get; set; }
    }
}
