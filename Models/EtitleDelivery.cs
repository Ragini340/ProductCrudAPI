using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EtitleDelivery
    {
        public int DocId { get; set; }
        public int? ClientId { get; set; }
        public int FileId { get; set; }
        public string? BatchId { get; set; }
        public string? Pdfname { get; set; }
        public string? ZipName { get; set; }
        public string? ProcessState { get; set; }
        public int? SourceId { get; set; }
        public int? DeliveryMethod { get; set; }
        public int? RequestId { get; set; }
        public string? Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long EventLogId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int EtitleDeliveryId { get; set; }
        public string? EventLogFileName { get; set; }
    }
}
