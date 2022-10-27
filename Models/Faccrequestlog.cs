using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Faccrequestlog
    {
        public int FaccrequestlogId { get; set; }
        public int FileId { get; set; }
        public string RequestXml { get; set; } = null!;
        public string ResponceXml { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
    }
}
