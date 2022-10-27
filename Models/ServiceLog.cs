using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string HostName { get; set; } = null!;
        public string Level { get; set; } = null!;
        public string Logger { get; set; } = null!;
        public string Thread { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string Exception { get; set; } = null!;
    }
}
