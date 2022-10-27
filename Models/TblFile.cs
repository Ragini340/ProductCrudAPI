using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TblFile
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public short? VStatus { get; set; }
    }
}
