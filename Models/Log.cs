using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Log
    {
        public string? Address { get; set; }
        public string? Attempts { get; set; }
        public string? Baudrate { get; set; }
        public string? ChargeCode { get; set; }
        public string? CompletionTime { get; set; }
        public string? CreationTime { get; set; }
        public string? FileName { get; set; }
        public string? FromName { get; set; }
        public string? ItemsSent { get; set; }
        public string? JobNumber { get; set; }
        public string? Message { get; set; }
        public string? ModemId { get; set; }
        public string? OboName { get; set; }
        public string? Priority { get; set; }
        public string? Status { get; set; }
        public string? Subject { get; set; }
        public string? SubmissionTime { get; set; }
        public string? Template { get; set; }
        public string? ToName { get; set; }
        public string? Number { get; set; }
        public string? OrlistName { get; set; }
        public string? TolistName { get; set; }
        public string? DeliveryStatus { get; set; }
        public string? RequestId { get; set; }
        public int LogId { get; set; }
        public int? EventLogId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? ServerId { get; set; }
        public int? DeliveryEventLogId { get; set; }
    }
}
