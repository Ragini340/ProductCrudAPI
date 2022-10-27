using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NpidataEncryption
    {
        public long Id { get; set; }
        public long TextId { get; set; }
        public string? TextData { get; set; }
        public string? KeyName { get; set; }
        public bool? IsEncrypted { get; set; }
        public bool? IsProcessed { get; set; }
        public string? OriginalTextData { get; set; }
    }
}
