using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrg
    {
        public BusOrg()
        {
            ApplSourceBusOrgInfos = new HashSet<ApplSourceBusOrgInfo>();
            BusOrgAlternateNames = new HashSet<BusOrgAlternateName>();
            BusOrgContactRelationships = new HashSet<BusOrgContactRelationship>();
            BusOrgContacts = new HashSet<BusOrgContact>();
            BusOrgEsubscriptionXrefs = new HashSet<BusOrgEsubscriptionXref>();
            BusOrgLicenseDetailsXrefs = new HashSet<BusOrgLicenseDetailsXref>();
            BusOrgMortgageProducts = new HashSet<BusOrgMortgageProduct>();
            BusOrgNotificationPrefs = new HashSet<BusOrgNotificationPref>();
            BusOrgRefBusOrgXrefOriginalBusOrgs = new HashSet<BusOrgRefBusOrgXref>();
            BusOrgRefBusOrgXrefReferenceBusOrgs = new HashSet<BusOrgRefBusOrgXref>();
            BusOrgRelationshipBusOrgs = new HashSet<BusOrgRelationship>();
            BusOrgRelationshipParentBusOrgs = new HashSet<BusOrgRelationship>();
            BusOrgSalesForceXrefs = new HashSet<BusOrgSalesForceXref>();
            BusOrgSecurityAgreements = new HashSet<BusOrgSecurityAgreement>();
            BusOrgWebCustomerXrefs = new HashSet<BusOrgWebCustomerXref>();
            BusinessProgramBusOrgChangeHistories = new HashSet<BusinessProgramBusOrgChangeHistory>();
            CoInsurancePolicyEstimates = new HashSet<CoInsurancePolicyEstimate>();
            FftbusOrgXrefs = new HashSet<FftbusOrgXref>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            GabentryRequestQueueBusOrgs = new HashSet<GabentryRequestQueue>();
            GabentryRequestQueueDuplicateBusOrgs = new HashSet<GabentryRequestQueue>();
            GabentryRequestQueueReferenceBusOrgs = new HashSet<GabentryRequestQueue>();
            GabrequestBusOrgReferences = new HashSet<GabrequestBusOrgReference>();
            InstructionBusOrgXrefs = new HashSet<InstructionBusOrgXref>();
            InterfaceDeliveryRequests = new HashSet<InterfaceDeliveryRequest>();
            InverseSuperBusOrg = new HashSet<BusOrg>();
            LoanInvestorBusOrgs = new HashSet<LoanInvestor>();
            LoanInvestorLoanInvestorBusOrgs = new HashSet<LoanInvestor>();
            OtherBusOrgs = new HashSet<OtherBusOrg>();
            PersonRelationships = new HashSet<PersonRelationship>();
            PreferredEmployeeContactXrefs = new HashSet<PreferredEmployeeContactXref>();
            Principals = new HashSet<Principal>();
            ProgramTypeBusOrgXrefs = new HashSet<ProgramTypeBusOrgXref>();
            ProgramTypeGeographicXrefs = new HashSet<ProgramTypeGeographicXref>();
            ProgramTypeProductTypeXrefs = new HashSet<ProgramTypeProductTypeXref>();
            ProgramTypeSearchTypeXrefs = new HashSet<ProgramTypeSearchTypeXref>();
            ProgramTypeTransTypeXrefs = new HashSet<ProgramTypeTransTypeXref>();
            RecordDocuments = new HashSet<RecordDocument>();
            Rtmaddresses = new HashSet<Rtmaddress>();
            SalesRepHistoryFromBusOrgs = new HashSet<SalesRepHistory>();
            SalesRepHistoryToBusOrgs = new HashSet<SalesRepHistory>();
            ServiceFileDeliveryInstructions = new HashSet<ServiceFileDeliveryInstruction>();
            SigningLoans = new HashSet<SigningLoan>();
            SolrUserFavoriteCustomers = new HashSet<SolrUserFavoriteCustomer>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
            WorkFlowTemplateBusOrgXrefs = new HashSet<WorkFlowTemplateBusOrgXref>();
            BusinessPrograms = new HashSet<BusinessProgram>();
        }

        public int BusOrgId { get; set; }
        public int ClassTypeId { get; set; }
        public int OrgTypeCdId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string? BillToBusOrgName1 { get; set; }
        public string? BillToBusOrgName2 { get; set; }
        public string? BillToPersonName { get; set; }
        public int? PrimarySalesEmployeeId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? SuperBusOrgId { get; set; }
        public int? PrimaryContactId { get; set; }
        public long? TitleInsMortgageeClauseTextId { get; set; }
        public long? HazardInsLossPayeeTextId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TitleAgentTypeCdId { get; set; }
        public string? FastStatCode { get; set; }
        public int? CorporateBusOrgId { get; set; }
        public int? ExternalCustomerFlag { get; set; }
        public int? WireInstId { get; set; }
        public short? StatusEmailFlag { get; set; }
        public int? IsNonInstitutional { get; set; }
        public short? StreamLineProcess { get; set; }
        public int? PrincipalTypeId { get; set; }
        public int? BusOrgCustomerOptionId { get; set; }
        public string? CustomerPreference { get; set; }
        public short? QcclosingClientFlag { get; set; }
        public long? EnterpriseId { get; set; }
        public string? EnterpriseNumber { get; set; }
        public string? EntryInstructions { get; set; }
        public int? OriginalBusOrgId { get; set; }
        public int? NextVersionBusOrgId { get; set; }
        public short? EcdCertifiedFlag { get; set; }
        public int? ReferenceBusOrgId { get; set; }
        public long? ProposedInsuredTextId { get; set; }
        public int? AgentOfficeId { get; set; }

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual BusinessUnit? AgentOffice { get; set; }
        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual CorporateBusOrg? CorporateBusOrg { get; set; }
        public virtual TypeCdDmt OrgTypeCd { get; set; } = null!;
        public virtual BusOrgContact? PrimaryContact { get; set; }
        public virtual Employee? PrimarySalesEmployee { get; set; }
        public virtual ClassType? PrincipalType { get; set; }
        public virtual BusOrg? SuperBusOrg { get; set; }
        public virtual TypeCdDmt? TitleAgentTypeCd { get; set; }
        public virtual BusOrgWireInstruction? WireInst { get; set; }
        public virtual BusorgSearchVendor? BusorgSearchVendor { get; set; }
        public virtual ICollection<ApplSourceBusOrgInfo> ApplSourceBusOrgInfos { get; set; }
        public virtual ICollection<BusOrgAlternateName> BusOrgAlternateNames { get; set; }
        public virtual ICollection<BusOrgContactRelationship> BusOrgContactRelationships { get; set; }
        public virtual ICollection<BusOrgContact> BusOrgContacts { get; set; }
        public virtual ICollection<BusOrgEsubscriptionXref> BusOrgEsubscriptionXrefs { get; set; }
        public virtual ICollection<BusOrgLicenseDetailsXref> BusOrgLicenseDetailsXrefs { get; set; }
        public virtual ICollection<BusOrgMortgageProduct> BusOrgMortgageProducts { get; set; }
        public virtual ICollection<BusOrgNotificationPref> BusOrgNotificationPrefs { get; set; }
        public virtual ICollection<BusOrgRefBusOrgXref> BusOrgRefBusOrgXrefOriginalBusOrgs { get; set; }
        public virtual ICollection<BusOrgRefBusOrgXref> BusOrgRefBusOrgXrefReferenceBusOrgs { get; set; }
        public virtual ICollection<BusOrgRelationship> BusOrgRelationshipBusOrgs { get; set; }
        public virtual ICollection<BusOrgRelationship> BusOrgRelationshipParentBusOrgs { get; set; }
        public virtual ICollection<BusOrgSalesForceXref> BusOrgSalesForceXrefs { get; set; }
        public virtual ICollection<BusOrgSecurityAgreement> BusOrgSecurityAgreements { get; set; }
        public virtual ICollection<BusOrgWebCustomerXref> BusOrgWebCustomerXrefs { get; set; }
        public virtual ICollection<BusinessProgramBusOrgChangeHistory> BusinessProgramBusOrgChangeHistories { get; set; }
        public virtual ICollection<CoInsurancePolicyEstimate> CoInsurancePolicyEstimates { get; set; }
        public virtual ICollection<FftbusOrgXref> FftbusOrgXrefs { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueBusOrgs { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueDuplicateBusOrgs { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueReferenceBusOrgs { get; set; }
        public virtual ICollection<GabrequestBusOrgReference> GabrequestBusOrgReferences { get; set; }
        public virtual ICollection<InstructionBusOrgXref> InstructionBusOrgXrefs { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequests { get; set; }
        public virtual ICollection<BusOrg> InverseSuperBusOrg { get; set; }
        public virtual ICollection<LoanInvestor> LoanInvestorBusOrgs { get; set; }
        public virtual ICollection<LoanInvestor> LoanInvestorLoanInvestorBusOrgs { get; set; }
        public virtual ICollection<OtherBusOrg> OtherBusOrgs { get; set; }
        public virtual ICollection<PersonRelationship> PersonRelationships { get; set; }
        public virtual ICollection<PreferredEmployeeContactXref> PreferredEmployeeContactXrefs { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
        public virtual ICollection<ProgramTypeBusOrgXref> ProgramTypeBusOrgXrefs { get; set; }
        public virtual ICollection<ProgramTypeGeographicXref> ProgramTypeGeographicXrefs { get; set; }
        public virtual ICollection<ProgramTypeProductTypeXref> ProgramTypeProductTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeSearchTypeXref> ProgramTypeSearchTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeTransTypeXref> ProgramTypeTransTypeXrefs { get; set; }
        public virtual ICollection<RecordDocument> RecordDocuments { get; set; }
        public virtual ICollection<Rtmaddress> Rtmaddresses { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistoryFromBusOrgs { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistoryToBusOrgs { get; set; }
        public virtual ICollection<ServiceFileDeliveryInstruction> ServiceFileDeliveryInstructions { get; set; }
        public virtual ICollection<SigningLoan> SigningLoans { get; set; }
        public virtual ICollection<SolrUserFavoriteCustomer> SolrUserFavoriteCustomers { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }
        public virtual ICollection<WorkFlowTemplateBusOrgXref> WorkFlowTemplateBusOrgXrefs { get; set; }

        public virtual ICollection<BusinessProgram> BusinessPrograms { get; set; }
    }
}
