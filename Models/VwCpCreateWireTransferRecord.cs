﻿using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwCpCreateWireTransferRecord
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? BusinessUnitId { get; set; }
        public string FileNum { get; set; } = null!;
        public int Disbursementid { get; set; }
        public string? DocumentNum { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? Amount { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Description { get; set; }
        public string? Description2 { get; set; }
        public int? AdjustedTransactionId { get; set; }
        public int? CorrectingTransactionId { get; set; }
        public int? DisbursementMethodTypeCdId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public string? PayeeName { get; set; }
        public string? SmsbankCd { get; set; }
        public string? AccountNum { get; set; }
        public string? Name1 { get; set; }
        public string? RoutingNum { get; set; }
        public string? IbabankAccNum { get; set; }
        public string? IbabankName { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public short? IsExchangeRegionFlag { get; set; }
    }
}
