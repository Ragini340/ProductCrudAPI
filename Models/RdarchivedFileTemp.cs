using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RdarchivedFileTemp
    {
        public int Fileid { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DocArchivedDate { get; set; }
        public DateTime? RunDate { get; set; }
        public short? Yr { get; set; }
        public short? Qr { get; set; }
    }
}
