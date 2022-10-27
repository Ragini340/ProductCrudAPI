using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RtmeventHistory
    {
        public long EventLogId { get; set; }
        public int RtmpackageId { get; set; }
        public string? PackageName { get; set; }
        public string? DocumentList { get; set; }
        public string? MailToList { get; set; }
        public string? ReturnToList { get; set; }
    }
}
