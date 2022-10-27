using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileService
    {
        public FileService()
        {
            FileServiceProductionOfficeXrefs = new HashSet<FileServiceProductionOfficeXref>();
            Rtmaddresses = new HashSet<Rtmaddress>();
        }

        public int FileServiceId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public int OwnerOfficeId { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? ExternalServiceNum { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? StateLicenseInformationId { get; set; }
        public string? StateLicenseNo { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual BusinessUnit OwnerOffice { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
        public virtual ICollection<FileServiceProductionOfficeXref> FileServiceProductionOfficeXrefs { get; set; }
        public virtual ICollection<Rtmaddress> Rtmaddresses { get; set; }
    }
}
