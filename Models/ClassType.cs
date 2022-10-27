using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClassType
    {
        public ClassType()
        {
            AccountingPrivacyEventLogs = new HashSet<AccountingPrivacyEventLog>();
            Activities = new HashSet<Activity>();
            ActivityGrps = new HashSet<ActivityGrp>();
            AddrBookEntries = new HashSet<AddrBookEntry>();
            Applications = new HashSet<Application>();
            ArbitraryNums = new HashSet<ArbitraryNum>();
            AtpsearchRules = new HashSet<AtpsearchRule>();
            AuthSignatures = new HashSet<AuthSignature>();
            BankAccounts = new HashSet<BankAccount>();
            BankBranches = new HashSet<BankBranch>();
            BusOrgClassTypes = new HashSet<BusOrg>();
            BusOrgContacts = new HashSet<BusOrgContact>();
            BusOrgPrincipalTypes = new HashSet<BusOrg>();
            BusUnitAutoNumbers = new HashSet<BusUnitAutoNumber>();
            BusinessProgramFileChangeHistories = new HashSet<BusinessProgramFileChangeHistory>();
            BusinessUnits = new HashSet<BusinessUnit>();
            Charges = new HashSet<Charge>();
            CheckDescriptionDetails = new HashSet<CheckDescriptionDetail>();
            CheckDisbursements = new HashSet<CheckDisbursement>();
            CheckTemplates = new HashSet<CheckTemplate>();
            ClassTypeTypeCdXrefs = new HashSet<ClassTypeTypeCdXref>();
            ClosingDisclosureEventLogClassTypes = new HashSet<ClosingDisclosureEventLog>();
            ClosingDisclosureEventLogEventSourceClassTypes = new HashSet<ClosingDisclosureEventLog>();
            CopyToDocPrefs = new HashSet<CopyToDocPref>();
            CorporateBusOrgs = new HashSet<CorporateBusOrg>();
            CountyInfos = new HashSet<CountyInfo>();
            CustomaryServiceFees = new HashSet<CustomaryServiceFee>();
            CustomerOrders = new HashSet<CustomerOrder>();
            DataElementDmts = new HashSet<DataElementDmt>();
            DataElementGrps = new HashSet<DataElementGrp>();
            DataElementIndexTypes = new HashSet<DataElementIndexType>();
            DeliveryEventLogs = new HashSet<DeliveryEventLog>();
            Disbursements = new HashSet<Disbursement>();
            DocTypeDmts = new HashSet<DocTypeDmt>();
            Docphraseelements = new HashSet<Docphraseelement>();
            Docphrases = new HashSet<Docphrase>();
            Documents = new HashSet<Document>();
            EarnestDeposits = new HashSet<EarnestDeposit>();
            ElectronicAddrs = new HashSet<ElectronicAddr>();
            Employees = new HashSet<Employee>();
            EscrowChargeTemplates = new HashSet<EscrowChargeTemplate>();
            EventLogOeClassTypes = new HashSet<EventLogOe>();
            EventLogOeEventSourceClassTypes = new HashSet<EventLogOe>();
            EventLogOeUpdSourceClassTypes = new HashSet<EventLogOe>();
            Events = new HashSet<Event>();
            ExportInfos = new HashSet<ExportInfo>();
            Fast1099sDetails = new HashSet<Fast1099sDetail>();
            Fees = new HashSet<Fee>();
            FieldTemplates = new HashSet<FieldTemplate>();
            FileAccounts = new HashSet<FileAccount>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            FileEntries = new HashSet<FileEntry>();
            FileProcesses = new HashSet<FileProcess>();
            FileServices = new HashSet<FileService>();
            FormDocuments = new HashSet<FormDocument>();
            FormTemplates = new HashSet<FormTemplate>();
            GabrefreshEventLogClassTypes = new HashSet<GabrefreshEventLog>();
            GabrefreshEventLogEventSourceClassTypes = new HashSet<GabrefreshEventLog>();
            GabrefreshEventLogUpdSourceClassTypes = new HashSet<GabrefreshEventLog>();
            GeographicRegions = new HashSet<GeographicRegion>();
            Gllookups = new HashSet<Gllookup>();
            GuinodeCustomizations = new HashSet<GuinodeCustomization>();
            Guinodes = new HashSet<Guinode>();
            Ibatransactions = new HashSet<Ibatransaction>();
            InEscrowDeposits = new HashSet<InEscrowDeposit>();
            IndexTypes = new HashSet<IndexType>();
            IntegrationServicesEventLogClassTypes = new HashSet<IntegrationServicesEventLog>();
            IntegrationServicesEventLogEventSourceClassTypes = new HashSet<IntegrationServicesEventLog>();
            IntegrationServicesEventLogUpdSourceClassTypes = new HashSet<IntegrationServicesEventLog>();
            InverseSuperClassType = new HashSet<ClassType>();
            Invoices = new HashSet<Invoice>();
            LicenseInformationLicenseCategoryClassTypes = new HashSet<LicenseInformation>();
            LicenseInformationLicenseEntityClassTypes = new HashSet<LicenseInformation>();
            MdmtypeCodeMappings = new HashSet<MdmtypeCodeMapping>();
            OtherBusOrgs = new HashSet<OtherBusOrg>();
            OutOfEscrowDeposits = new HashSet<OutOfEscrowDeposit>();
            Packages = new HashSet<Package>();
            Payments = new HashSet<Payment>();
            PhraseElements = new HashSet<PhraseElement>();
            PhraseGrps = new HashSet<PhraseGrp>();
            PhraseMarkerForms = new HashSet<PhraseMarkerForm>();
            PhraseMarkers = new HashSet<PhraseMarker>();
            Phrases = new HashSet<Phrase>();
            PhysicalAddrs = new HashSet<PhysicalAddr>();
            PreferredDocLists = new HashSet<PreferredDocList>();
            PrincipalAddInfos = new HashSet<PrincipalAddInfo>();
            PrincipalBusEntities = new HashSet<PrincipalBusEntity>();
            Principals = new HashSet<Principal>();
            RealProperties = new HashSet<RealProperty>();
            RecordDocuments = new HashSet<RecordDocument>();
            RecordedDocEventLogClassTypes = new HashSet<RecordedDocEventLog>();
            RecordedDocEventLogEventSourceClassTypes = new HashSet<RecordedDocEventLog>();
            RecordedDocEventLogUpdSourceClassTypes = new HashSet<RecordedDocEventLog>();
            RecordingEventLogClassTypes = new HashSet<RecordingEventLog>();
            RecordingEventLogEventSourceClassTypes = new HashSet<RecordingEventLog>();
            RecordingEventLogUpdSourceClassTypes = new HashSet<RecordingEventLog>();
            RecordingInfos = new HashSet<RecordingInfo>();
            RegionalSettings = new HashSet<RegionalSetting>();
            Roles = new HashSet<Role>();
            SdnsearchQs = new HashSet<SdnsearchQ>();
            Sdntrackings = new HashSet<Sdntracking>();
            SearchFactTypes = new HashSet<SearchFactType>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            ServiceFileNotes = new HashSet<ServiceFileNote>();
            ServiceFileTagFileXrefs = new HashSet<ServiceFileTagFileXref>();
            ServiceFiles = new HashSet<ServiceFile>();
            SigningEventLogClassTypes = new HashSet<SigningEventLog>();
            SigningEventLogEventSourceClassTypes = new HashSet<SigningEventLog>();
            SigningEventLogUpdSourceClassTypes = new HashSet<SigningEventLog>();
            TaxExemptions = new HashSet<TaxExemption>();
            TaxInstallments = new HashSet<TaxInstallment>();
            TaxRateInfos = new HashSet<TaxRateInfo>();
            Taxes = new HashSet<Tax>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
            TemplateFilterGrpGeoRegionXrefDocPreps = new HashSet<TemplateFilterGrpGeoRegionXrefDocPrep>();
            TemplateFilterGrpGeoRegionXrefs = new HashSet<TemplateFilterGrpGeoRegionXref>();
            TemplatePageLayouts = new HashSet<TemplatePageLayout>();
            TemplatePhrases = new HashSet<TemplatePhrase>();
            Templates = new HashSet<Template>();
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
            ToleranceCures = new HashSet<ToleranceCure>();
            TypeCdDmts = new HashSet<TypeCdDmt>();
            UserFavorites = new HashSet<UserFavorite>();
            WorkflowSequences = new HashSet<WorkflowSequence>();
            Workflows = new HashSet<Workflow>();
            DocTypeCds = new HashSet<DocTypeDmt>();
        }

        public int ClassTypeId { get; set; }
        public int? SuperClassTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? TableName { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType? SuperClassType { get; set; }
        public virtual ICollection<AccountingPrivacyEventLog> AccountingPrivacyEventLogs { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ActivityGrp> ActivityGrps { get; set; }
        public virtual ICollection<AddrBookEntry> AddrBookEntries { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<ArbitraryNum> ArbitraryNums { get; set; }
        public virtual ICollection<AtpsearchRule> AtpsearchRules { get; set; }
        public virtual ICollection<AuthSignature> AuthSignatures { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<BankBranch> BankBranches { get; set; }
        public virtual ICollection<BusOrg> BusOrgClassTypes { get; set; }
        public virtual ICollection<BusOrgContact> BusOrgContacts { get; set; }
        public virtual ICollection<BusOrg> BusOrgPrincipalTypes { get; set; }
        public virtual ICollection<BusUnitAutoNumber> BusUnitAutoNumbers { get; set; }
        public virtual ICollection<BusinessProgramFileChangeHistory> BusinessProgramFileChangeHistories { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual ICollection<CheckDescriptionDetail> CheckDescriptionDetails { get; set; }
        public virtual ICollection<CheckDisbursement> CheckDisbursements { get; set; }
        public virtual ICollection<CheckTemplate> CheckTemplates { get; set; }
        public virtual ICollection<ClassTypeTypeCdXref> ClassTypeTypeCdXrefs { get; set; }
        public virtual ICollection<ClosingDisclosureEventLog> ClosingDisclosureEventLogClassTypes { get; set; }
        public virtual ICollection<ClosingDisclosureEventLog> ClosingDisclosureEventLogEventSourceClassTypes { get; set; }
        public virtual ICollection<CopyToDocPref> CopyToDocPrefs { get; set; }
        public virtual ICollection<CorporateBusOrg> CorporateBusOrgs { get; set; }
        public virtual ICollection<CountyInfo> CountyInfos { get; set; }
        public virtual ICollection<CustomaryServiceFee> CustomaryServiceFees { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmts { get; set; }
        public virtual ICollection<DataElementGrp> DataElementGrps { get; set; }
        public virtual ICollection<DataElementIndexType> DataElementIndexTypes { get; set; }
        public virtual ICollection<DeliveryEventLog> DeliveryEventLogs { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<DocTypeDmt> DocTypeDmts { get; set; }
        public virtual ICollection<Docphraseelement> Docphraseelements { get; set; }
        public virtual ICollection<Docphrase> Docphrases { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<EarnestDeposit> EarnestDeposits { get; set; }
        public virtual ICollection<ElectronicAddr> ElectronicAddrs { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplates { get; set; }
        public virtual ICollection<EventLogOe> EventLogOeClassTypes { get; set; }
        public virtual ICollection<EventLogOe> EventLogOeEventSourceClassTypes { get; set; }
        public virtual ICollection<EventLogOe> EventLogOeUpdSourceClassTypes { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ExportInfo> ExportInfos { get; set; }
        public virtual ICollection<Fast1099sDetail> Fast1099sDetails { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<FieldTemplate> FieldTemplates { get; set; }
        public virtual ICollection<FileAccount> FileAccounts { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<FileEntry> FileEntries { get; set; }
        public virtual ICollection<FileProcess> FileProcesses { get; set; }
        public virtual ICollection<FileService> FileServices { get; set; }
        public virtual ICollection<FormDocument> FormDocuments { get; set; }
        public virtual ICollection<FormTemplate> FormTemplates { get; set; }
        public virtual ICollection<GabrefreshEventLog> GabrefreshEventLogClassTypes { get; set; }
        public virtual ICollection<GabrefreshEventLog> GabrefreshEventLogEventSourceClassTypes { get; set; }
        public virtual ICollection<GabrefreshEventLog> GabrefreshEventLogUpdSourceClassTypes { get; set; }
        public virtual ICollection<GeographicRegion> GeographicRegions { get; set; }
        public virtual ICollection<Gllookup> Gllookups { get; set; }
        public virtual ICollection<GuinodeCustomization> GuinodeCustomizations { get; set; }
        public virtual ICollection<Guinode> Guinodes { get; set; }
        public virtual ICollection<Ibatransaction> Ibatransactions { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDeposits { get; set; }
        public virtual ICollection<IndexType> IndexTypes { get; set; }
        public virtual ICollection<IntegrationServicesEventLog> IntegrationServicesEventLogClassTypes { get; set; }
        public virtual ICollection<IntegrationServicesEventLog> IntegrationServicesEventLogEventSourceClassTypes { get; set; }
        public virtual ICollection<IntegrationServicesEventLog> IntegrationServicesEventLogUpdSourceClassTypes { get; set; }
        public virtual ICollection<ClassType> InverseSuperClassType { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<LicenseInformation> LicenseInformationLicenseCategoryClassTypes { get; set; }
        public virtual ICollection<LicenseInformation> LicenseInformationLicenseEntityClassTypes { get; set; }
        public virtual ICollection<MdmtypeCodeMapping> MdmtypeCodeMappings { get; set; }
        public virtual ICollection<OtherBusOrg> OtherBusOrgs { get; set; }
        public virtual ICollection<OutOfEscrowDeposit> OutOfEscrowDeposits { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PhraseElement> PhraseElements { get; set; }
        public virtual ICollection<PhraseGrp> PhraseGrps { get; set; }
        public virtual ICollection<PhraseMarkerForm> PhraseMarkerForms { get; set; }
        public virtual ICollection<PhraseMarker> PhraseMarkers { get; set; }
        public virtual ICollection<Phrase> Phrases { get; set; }
        public virtual ICollection<PhysicalAddr> PhysicalAddrs { get; set; }
        public virtual ICollection<PreferredDocList> PreferredDocLists { get; set; }
        public virtual ICollection<PrincipalAddInfo> PrincipalAddInfos { get; set; }
        public virtual ICollection<PrincipalBusEntity> PrincipalBusEntities { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
        public virtual ICollection<RealProperty> RealProperties { get; set; }
        public virtual ICollection<RecordDocument> RecordDocuments { get; set; }
        public virtual ICollection<RecordedDocEventLog> RecordedDocEventLogClassTypes { get; set; }
        public virtual ICollection<RecordedDocEventLog> RecordedDocEventLogEventSourceClassTypes { get; set; }
        public virtual ICollection<RecordedDocEventLog> RecordedDocEventLogUpdSourceClassTypes { get; set; }
        public virtual ICollection<RecordingEventLog> RecordingEventLogClassTypes { get; set; }
        public virtual ICollection<RecordingEventLog> RecordingEventLogEventSourceClassTypes { get; set; }
        public virtual ICollection<RecordingEventLog> RecordingEventLogUpdSourceClassTypes { get; set; }
        public virtual ICollection<RecordingInfo> RecordingInfos { get; set; }
        public virtual ICollection<RegionalSetting> RegionalSettings { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<SdnsearchQ> SdnsearchQs { get; set; }
        public virtual ICollection<Sdntracking> Sdntrackings { get; set; }
        public virtual ICollection<SearchFactType> SearchFactTypes { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
        public virtual ICollection<ServiceFileNote> ServiceFileNotes { get; set; }
        public virtual ICollection<ServiceFileTagFileXref> ServiceFileTagFileXrefs { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
        public virtual ICollection<SigningEventLog> SigningEventLogClassTypes { get; set; }
        public virtual ICollection<SigningEventLog> SigningEventLogEventSourceClassTypes { get; set; }
        public virtual ICollection<SigningEventLog> SigningEventLogUpdSourceClassTypes { get; set; }
        public virtual ICollection<TaxExemption> TaxExemptions { get; set; }
        public virtual ICollection<TaxInstallment> TaxInstallments { get; set; }
        public virtual ICollection<TaxRateInfo> TaxRateInfos { get; set; }
        public virtual ICollection<Tax> Taxes { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }
        public virtual ICollection<TemplateFilterGrpGeoRegionXrefDocPrep> TemplateFilterGrpGeoRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterGrpGeoRegionXref> TemplateFilterGrpGeoRegionXrefs { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayouts { get; set; }
        public virtual ICollection<TemplatePhrase> TemplatePhrases { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
        public virtual ICollection<ToleranceCure> ToleranceCures { get; set; }
        public virtual ICollection<TypeCdDmt> TypeCdDmts { get; set; }
        public virtual ICollection<UserFavorite> UserFavorites { get; set; }
        public virtual ICollection<WorkflowSequence> WorkflowSequences { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }

        public virtual ICollection<DocTypeDmt> DocTypeCds { get; set; }
    }
}
