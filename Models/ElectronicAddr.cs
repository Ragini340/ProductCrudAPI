using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ElectronicAddr
    {
        public ElectronicAddr()
        {
            AddrBookElecAddrXrefs = new HashSet<AddrBookElecAddrXref>();
            BusOrgAndContactElectronicAddrXrefElectronicAddrs = new HashSet<BusOrgAndContactElectronicAddrXref>();
            BusOrgAndContactElectronicAddrXrefOriginalElectronicAddrs = new HashSet<BusOrgAndContactElectronicAddrXref>();
            BusOrgContactNotificationPrefs = new HashSet<BusOrgContactNotificationPref>();
            BusOrgNotificationPrefs = new HashSet<BusOrgNotificationPref>();
            EmployeeNotificationPrefs = new HashSet<EmployeeNotificationPref>();
            PersonNotificationPrefs = new HashSet<PersonNotificationPref>();
            PrincipalNotifications = new HashSet<PrincipalNotification>();
            SigningPartyElecAddrXrefs = new HashSet<SigningPartyElecAddrXref>();
        }

        public int ElectronicAddrId { get; set; }
        public int ClassTypeId { get; set; }
        public int? ContextTypeCdId { get; set; }
        public string? CountryCd { get; set; }
        public string? CallOut { get; set; }
        public string? AreaCode { get; set; }
        public string? PhoneNum { get; set; }
        public string? Extension { get; set; }
        public string? Email { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public long? EnterpriseId { get; set; }
        public int? StatusCd { get; set; }
        public short? MdmprimaryFlag { get; set; }
        public short? MdmprimaryByPurposeFlag { get; set; }
        public short? LocalPrimaryFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<AddrBookElecAddrXref> AddrBookElecAddrXrefs { get; set; }
        public virtual ICollection<BusOrgAndContactElectronicAddrXref> BusOrgAndContactElectronicAddrXrefElectronicAddrs { get; set; }
        public virtual ICollection<BusOrgAndContactElectronicAddrXref> BusOrgAndContactElectronicAddrXrefOriginalElectronicAddrs { get; set; }
        public virtual ICollection<BusOrgContactNotificationPref> BusOrgContactNotificationPrefs { get; set; }
        public virtual ICollection<BusOrgNotificationPref> BusOrgNotificationPrefs { get; set; }
        public virtual ICollection<EmployeeNotificationPref> EmployeeNotificationPrefs { get; set; }
        public virtual ICollection<PersonNotificationPref> PersonNotificationPrefs { get; set; }
        public virtual ICollection<PrincipalNotification> PrincipalNotifications { get; set; }
        public virtual ICollection<SigningPartyElecAddrXref> SigningPartyElecAddrXrefs { get; set; }
    }
}
