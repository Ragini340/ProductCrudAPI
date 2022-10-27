using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TmpTasksToCancel
    {
        public int Rowid { get; set; }
        public int Fileid { get; set; }
        public byte? Processed { get; set; }
        public string? ErrorMsg { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
