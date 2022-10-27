using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CorporateBusOrg
    {
        public CorporateBusOrg()
        {
            BatchDemandLoanInfos = new HashSet<BatchDemandLoanInfo>();
            BusOrgs = new HashSet<BusOrg>();
            CorpEbusInterfaceFormatXrefs = new HashSet<CorpEbusInterfaceFormatXref>();
            EbusinessRequests = new HashSet<EbusinessRequest>();
            EtitleBusinessUnits = new HashSet<EtitleBusinessUnit>();
            BusinessUnits = new HashSet<BusinessUnit>();
        }

        public int CorporateBusOrgId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int AddressBookId { get; set; }
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<BatchDemandLoanInfo> BatchDemandLoanInfos { get; set; }
        public virtual ICollection<BusOrg> BusOrgs { get; set; }
        public virtual ICollection<CorpEbusInterfaceFormatXref> CorpEbusInterfaceFormatXrefs { get; set; }
        public virtual ICollection<EbusinessRequest> EbusinessRequests { get; set; }
        public virtual ICollection<EtitleBusinessUnit> EtitleBusinessUnits { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
    }
}
