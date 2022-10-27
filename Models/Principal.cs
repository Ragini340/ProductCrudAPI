using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Principal
    {
        public Principal()
        {
            AuthSignatures = new HashSet<AuthSignature>();
            CoInsurancePrincipalXrefs = new HashSet<CoInsurancePrincipalXref>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            PolicyPrincipalXrefDocPreps = new HashSet<PolicyPrincipalXrefDocPrep>();
            PrincipalAddInfos = new HashSet<PrincipalAddInfo>();
            PrincipalBusEntities = new HashSet<PrincipalBusEntity>();
            ServiceFileDeliveryInstructions = new HashSet<ServiceFileDeliveryInstruction>();
            SigningParties = new HashSet<SigningParty>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
            Documents = new HashSet<Document>();
            Endorsements = new HashSet<Endorsement>();
            GeoRegions = new HashSet<GeographicRegion>();
            PersonalProperties = new HashSet<PersonalProperty>();
            Properties = new HashSet<RealProperty>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
        }

        public int PrincipalId { get; set; }
        public int ClassTypeId { get; set; }
        public int TypeCdId { get; set; }
        public int? StaticSeqNum { get; set; }
        public int? AddrBookEntryId { get; set; }
        public int? VestingTypeCdId { get; set; }
        public int? SpouseInfoId { get; set; }
        public string? Name { get; set; }
        public string? Vesting { get; set; }
        public int? VestingMaritalStatusTypeCdId { get; set; }
        public string? AddtlVestingInfo { get; set; }
        public short UseAkawithSigFlag { get; set; }
        public string? Salutation { get; set; }
        public int? StateOfIncGeoRegionId { get; set; }
        public int? OrgTypeCdId { get; set; }
        public DateTime? TrustDate { get; set; }
        public string? TrustNumber { get; set; }
        public string? TrustShortName { get; set; }
        public string? RefNum1 { get; set; }
        public string? RefNum2 { get; set; }
        public string? StateOfResidence { get; set; }
        public string? OtherStatesOfResidence { get; set; }
        public int? NumberOfPlacesOfBusiness { get; set; }
        public string? StateOfSolePlaceOfBusiness { get; set; }
        public string? OtherStatesOfSolePlaceOfBusiness { get; set; }
        public int? HasOtherLegalNamesFlag { get; set; }
        public short? DebtorOpBusinessFiveYearFlag { get; set; }
        public int? FormerAddrBookEntryId { get; set; }
        public int? FinancingStatementId { get; set; }
        public int? SecurityAgreementXrefNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? LastName1099S { get; set; }
        public int? Sms1099classificationCdId { get; set; }
        public int? Spouse1099ClassificationCdId { get; set; }
        public int? BusOrgId { get; set; }
        public int? EmployedById { get; set; }
        public short? LoanApplicantFlag { get; set; }
        public short? SpouseLoanApplicantFlag { get; set; }

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual BusOrg? BusOrg { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual EmployedBy? EmployedBy { get; set; }
        public virtual AddrBookEntry? FormerAddrBookEntry { get; set; }
        public virtual TypeCdDmt? OrgTypeCd { get; set; }
        public virtual TypeCdDmt? Sms1099classificationCd { get; set; }
        public virtual TypeCdDmt? Spouse1099ClassificationCd { get; set; }
        public virtual AddrBookEntry? SpouseInfo { get; set; }
        public virtual GeographicRegion? StateOfIncGeoRegion { get; set; }
        public virtual TypeCdDmt TypeCd { get; set; } = null!;
        public virtual TypeCdDmt? VestingMaritalStatusTypeCd { get; set; }
        public virtual TypeCdDmt? VestingTypeCd { get; set; }
        public virtual ICollection<AuthSignature> AuthSignatures { get; set; }
        public virtual ICollection<CoInsurancePrincipalXref> CoInsurancePrincipalXrefs { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<PolicyPrincipalXrefDocPrep> PolicyPrincipalXrefDocPreps { get; set; }
        public virtual ICollection<PrincipalAddInfo> PrincipalAddInfos { get; set; }
        public virtual ICollection<PrincipalBusEntity> PrincipalBusEntities { get; set; }
        public virtual ICollection<ServiceFileDeliveryInstruction> ServiceFileDeliveryInstructions { get; set; }
        public virtual ICollection<SigningParty> SigningParties { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Endorsement> Endorsements { get; set; }
        public virtual ICollection<GeographicRegion> GeoRegions { get; set; }
        public virtual ICollection<PersonalProperty> PersonalProperties { get; set; }
        public virtual ICollection<RealProperty> Properties { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
    }
}
