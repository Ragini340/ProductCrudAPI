using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CountyInfo
    {
        public CountyInfo()
        {
            CountyInfoPhraseXrefDocPreps = new HashSet<CountyInfoPhraseXrefDocPrep>();
            EmployeeCountyInfoXrefs = new HashSet<EmployeeCountyInfoXref>();
            Phrases = new HashSet<Phrase>();
        }

        public int CountyInfoId { get; set; }
        public int ClassTypeId { get; set; }
        public int GeoRegionId { get; set; }
        public int? DefaultOwnerOfficeId { get; set; }
        public int? DefaultProductionOfficeId { get; set; }
        public short FastSearchAvailableFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual BusinessUnit? DefaultOwnerOffice { get; set; }
        public virtual BusinessUnit? DefaultProductionOffice { get; set; }
        public virtual GeographicRegion GeoRegion { get; set; } = null!;
        public virtual ICollection<CountyInfoPhraseXrefDocPrep> CountyInfoPhraseXrefDocPreps { get; set; }
        public virtual ICollection<EmployeeCountyInfoXref> EmployeeCountyInfoXrefs { get; set; }

        public virtual ICollection<Phrase> Phrases { get; set; }
    }
}
