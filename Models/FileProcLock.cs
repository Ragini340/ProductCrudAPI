using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileProcLock
    {
        public int? FileId { get; set; }
        public string? LockProcDesc { get; set; }
        public int? UserId { get; set; }
        public int? SessionId { get; set; }
        public DateTime? WhenIssued { get; set; }
        public int FileProcLockId { get; set; }
    }
}
