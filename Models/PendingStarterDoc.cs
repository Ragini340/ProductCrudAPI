using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PendingStarterDoc
    {
        public int FileId { get; set; }
        public string? StateCd { get; set; }
        public string? CountyName { get; set; }
        public DateTime? OpenDate { get; set; }
        public byte[]? UpdTs { get; set; }
        public Guid? BatchId { get; set; }
        public int? Status { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
