using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AccountingPrivacyEventLogs = new HashSet<AccountingPrivacyEventLog>();
            AddrBookEntryCreationEmployees = new HashSet<AddrBookEntry>();
            AddrBookEntryStatusChgEmployees = new HashSet<AddrBookEntry>();
            AgentNetValidationRequestStatuses = new HashSet<AgentNetValidationRequestStatus>();
            AlternateBankChangeHistories = new HashSet<AlternateBankChangeHistory>();
            Applications = new HashSet<Application>();
            BusOrgContactRelationshipChangeHistories = new HashSet<BusOrgContactRelationshipChangeHistory>();
            BusOrgContacts = new HashSet<BusOrgContact>();
            BusOrgRelationshipChangeHistories = new HashSet<BusOrgRelationshipChangeHistory>();
            BusOrgs = new HashSet<BusOrg>();
            BusinessProgramBusOrgChangeHistories = new HashSet<BusinessProgramBusOrgChangeHistory>();
            BusinessProgramBusOrgContactChangeHistories = new HashSet<BusinessProgramBusOrgContactChangeHistory>();
            BusinessProgramBusUnitChangeHistories = new HashSet<BusinessProgramBusUnitChangeHistory>();
            BusinessSourceTypeCreationEmployees = new HashSet<BusinessSourceType>();
            BusinessSourceTypeStatusChgUsers = new HashSet<BusinessSourceType>();
            BusinessSourceTypeUpdatedEmployees = new HashSet<BusinessSourceType>();
            BusinessUnitCreationUsers = new HashSet<BusinessUnit>();
            BusinessUnitStatusChgUsers = new HashSet<BusinessUnit>();
            ChangeOwningOfficeHistories = new HashSet<ChangeOwningOfficeHistory>();
            ChargeCreationEmployees = new HashSet<Charge>();
            ChargeResequenceCreationUsers = new HashSet<ChargeResequence>();
            ChargeResequenceLastModifiedUsers = new HashSet<ChargeResequence>();
            ChargeUpdatedEmployees = new HashSet<Charge>();
            CorpCpuproductionOfficeCreatedUsers = new HashSet<CorpCpuproductionOffice>();
            CorpCpuproductionOfficeModifiedUsers = new HashSet<CorpCpuproductionOffice>();
            DeliveryEventLogs = new HashSet<DeliveryEventLog>();
            DepositLists = new HashSet<DepositList>();
            DisbursementHeldByEmployees = new HashSet<Disbursement>();
            DisbursementIssuedByEmployees = new HashSet<Disbursement>();
            DisbursementReleasedByEmployees = new HashSet<Disbursement>();
            DisbursementSplitByEmployees = new HashSet<Disbursement>();
            Docphrases = new HashSet<Docphrase>();
            DocumentLicenseInfoFinalizedEmployees = new HashSet<DocumentLicenseInfo>();
            DocumentLicenseInfoLicensedEmployees = new HashSet<DocumentLicenseInfo>();
            DocumentLicenseInfoRequestedEmployees = new HashSet<DocumentLicenseInfo>();
            Documents = new HashSet<Document>();
            EbusinessRequests = new HashSet<EbusinessRequest>();
            EcheckDetails = new HashSet<EcheckDetail>();
            EmployedByCreationEmployees = new HashSet<EmployedBy>();
            EmployedByStatusChgUsers = new HashSet<EmployedBy>();
            EmployedByUpdatedEmployees = new HashSet<EmployedBy>();
            EmployeeFunctionXrefs = new HashSet<EmployeeFunctionXref>();
            EmployeeNotificationPrefs = new HashSet<EmployeeNotificationPref>();
            EmployeeOverdraftEmailOptOutLists = new HashSet<EmployeeOverdraftEmailOptOutList>();
            EmployeeSecurityChangeHistoryEmployees = new HashSet<EmployeeSecurityChangeHistory>();
            EmployeeSecurityChangeHistoryUsers = new HashSet<EmployeeSecurityChangeHistory>();
            EmployeeWorkgroupXrefs = new HashSet<EmployeeWorkgroupXref>();
            EventCreationUsers = new HashSet<Event>();
            EventStatusChgUsers = new HashSet<Event>();
            FaccclosingCosts = new HashSet<FaccclosingCost>();
            Faccendorsements = new HashSet<Faccendorsement>();
            FaccrecordingFees = new HashSet<FaccrecordingFee>();
            FacctitlePolicies = new HashSet<FacctitlePolicy>();
            FaxGroups = new HashSet<FaxGroup>();
            FeeFilterTemplateCreatedUsers = new HashSet<FeeFilterTemplate>();
            FeeFilterTemplateStatusChgUsers = new HashSet<FeeFilterTemplate>();
            FeeSetupChangeHistories = new HashSet<FeeSetupChangeHistory>();
            FftchangeHistories = new HashSet<FftchangeHistory>();
            FileBusinessPartySales1Employees = new HashSet<FileBusinessParty>();
            FileBusinessPartySales2Employees = new HashSet<FileBusinessParty>();
            FileProcessCreationEmployees = new HashSet<FileProcess>();
            FileProcessUpdatedEmployees = new HashSet<FileProcess>();
            FileServiceProductionOfficeXrefAssistants = new HashSet<FileServiceProductionOfficeXref>();
            FileServiceProductionOfficeXrefOfficers = new HashSet<FileServiceProductionOfficeXref>();
            GabentryRequestQueueLockedByUsers = new HashSet<GabentryRequestQueue>();
            GabentryRequestQueueRequestors = new HashSet<GabentryRequestQueue>();
            GenericEmails = new HashSet<GenericEmail>();
            GroupResequenceCreationUsers = new HashSet<GroupResequence>();
            GroupResequenceLastModifiedUsers = new HashSet<GroupResequence>();
            HudDeliveryVersionings = new HashSet<HudDeliveryVersioning>();
            IbabankAccounts = new HashSet<IbabankAccount>();
            IbabankBranchCreationEmployees = new HashSet<IbabankBranch>();
            IbabankBranchCurrStatusUsers = new HashSet<IbabankBranch>();
            IbabankProducts = new HashSet<IbabankProduct>();
            IbabankStatusChangeXrefs = new HashSet<IbabankStatusChangeXref>();
            IbatransactionAdjustmentLogs = new HashSet<IbatransactionAdjustmentLog>();
            InEscrowDepositCreationEmployees = new HashSet<InEscrowDeposit>();
            InEscrowDepositExcludeEmployees = new HashSet<InEscrowDeposit>();
            IncomingWireDetails = new HashSet<IncomingWireDetail>();
            IncomingWireDisbursements = new HashSet<IncomingWireDisbursement>();
            InstructionCreationEmployees = new HashSet<Instruction>();
            InstructionStatusChangeUsers = new HashSet<Instruction>();
            InstructionUpdatedEmployees = new HashSet<Instruction>();
            InterfaceDeliveryRequests = new HashSet<InterfaceDeliveryRequest>();
            InvoiceHistoryEscrowOfficers = new HashSet<InvoiceHistory>();
            InvoiceHistoryTitleOfficers = new HashSet<InvoiceHistory>();
            Invoices = new HashSet<Invoice>();
            LicenseInformationCreationUsers = new HashSet<LicenseInformation>();
            LicenseInformationDeActivationByNavigations = new HashSet<LicenseInformation>();
            LicenseInformationLogs = new HashSet<LicenseInformationLog>();
            LicenseInformationReActivationByNavigations = new HashSet<LicenseInformation>();
            LicenseTypeGeoRegionXrefCreationUsers = new HashSet<LicenseTypeGeoRegionXref>();
            LicenseTypeGeoRegionXrefDeactivationUsers = new HashSet<LicenseTypeGeoRegionXref>();
            LicenseTypeGeoRegionXrefReactivationUsers = new HashSet<LicenseTypeGeoRegionXref>();
            NotificationTemplateCreatedUsers = new HashSet<NotificationTemplate>();
            NotificationTemplateStatusChgUsers = new HashSet<NotificationTemplate>();
            OfficeUnderwriterCreationEmployees = new HashSet<OfficeUnderwriter>();
            OfficeUnderwriterStatusChgUsers = new HashSet<OfficeUnderwriter>();
            OfficeUnderwriterUpdatedEmployees = new HashSet<OfficeUnderwriter>();
            PersonBpchangeHistories = new HashSet<PersonBpchangeHistory>();
            PersonRelationshipChangeHistories = new HashSet<PersonRelationshipChangeHistory>();
            PersonSalesRep1Navigations = new HashSet<Person>();
            PersonSalesRep2Navigations = new HashSet<Person>();
            PhraseCreationUsers = new HashSet<Phrase>();
            PhraseHistories = new HashSet<PhraseHistory>();
            PhraseMarkerFormVersions = new HashSet<PhraseMarkerFormVersion>();
            PhraseMarkerForms = new HashSet<PhraseMarkerForm>();
            PhraseStatusChgUsers = new HashSet<Phrase>();
            PreferredBusOrgContactXrefs = new HashSet<PreferredBusOrgContactXref>();
            PreferredEmployeeContactXrefs = new HashSet<PreferredEmployeeContactXref>();
            PreferredPersonXrefs = new HashSet<PreferredPersonXref>();
            PrintPreferences = new HashSet<PrintPreference>();
            ProfileChangeHistories = new HashSet<ProfileChangeHistory>();
            QcstagingSectionCharges = new HashSet<QcstagingSectionCharge>();
            QcstagingSectionXrefs = new HashSet<QcstagingSectionXref>();
            RegionUnderwriterCreationEmployees = new HashSet<RegionUnderwriter>();
            RegionUnderwriterStatusChgUsers = new HashSet<RegionUnderwriter>();
            RegionUnderwriterUpdatedEmployees = new HashSet<RegionUnderwriter>();
            ReserveFileUseds = new HashSet<ReserveFileUsed>();
            ReserveFiles = new HashSet<ReserveFile>();
            RoleChangeHistories = new HashSet<RoleChangeHistory>();
            RuleListCreatedByNavigations = new HashSet<RuleList>();
            RuleListDeActivationByNavigations = new HashSet<RuleList>();
            RuleListLastUpdatedByNavigations = new HashSet<RuleList>();
            RuleListReActivationByNavigations = new HashSet<RuleList>();
            SalesRepHistoryFromSalesRepId1Navigations = new HashSet<SalesRepHistory>();
            SalesRepHistoryFromSalesRepId2Navigations = new HashSet<SalesRepHistory>();
            SalesRepHistoryToSalesRepId1Navigations = new HashSet<SalesRepHistory>();
            SalesRepHistoryToSalesRepId2Navigations = new HashSet<SalesRepHistory>();
            SecOffcGrpChangeHistories = new HashSet<SecOffcGrpChangeHistory>();
            SectionResequenceCreationUsers = new HashSet<SectionResequence>();
            SectionResequenceLastModifiedUsers = new HashSet<SectionResequence>();
            ServiceFileCreationUsers = new HashSet<ServiceFile>();
            ServiceFileEmployeeXrefs = new HashSet<ServiceFileEmployeeXref>();
            ServiceFileNoteCreationEmployees = new HashSet<ServiceFileNote>();
            ServiceFileNoteUpdatedEmployees = new HashSet<ServiceFileNote>();
            ServiceFileSalesReps = new HashSet<ServiceFile>();
            ServiceFileStatusChgUsers = new HashSet<ServiceFile>();
            SigningParties = new HashSet<SigningParty>();
            Signings = new HashSet<Signing>();
            SolrUserFavoriteCustomers = new HashSet<SolrUserFavoriteCustomer>();
            SymentecVipauditLogs = new HashSet<SymentecVipauditLog>();
            TaskCategories = new HashSet<TaskCategory>();
            TemplateBusinessPartySales1Employees = new HashSet<TemplateBusinessParty>();
            TemplateBusinessPartySales2Employees = new HashSet<TemplateBusinessParty>();
            TemplateCreationUsers = new HashSet<Template>();
            TemplateHistories = new HashSet<TemplateHistory>();
            TemplateStatusChgUsers = new HashSet<Template>();
            ThresholdAmountChangeHistories = new HashSet<ThresholdAmountChangeHistory>();
            UserBusUnitXrefs = new HashSet<UserBusUnitXref>();
            UserFavorites = new HashSet<UserFavorite>();
            UserGuipreferences = new HashSet<UserGuipreference>();
            UserSecOffcGrpXrefs = new HashSet<UserSecOffcGrpXref>();
            VendorInfos = new HashSet<VendorInfo>();
            WorkFlowTemplateChangeHistories = new HashSet<WorkFlowTemplateChangeHistory>();
            WorkFlowTemplates = new HashSet<WorkFlowTemplate>();
            WorkGroupCreationUsers = new HashSet<WorkGroup>();
            WorkGroupStatusChgUsers = new HashSet<WorkGroup>();
            WorkQueueEmailBodies = new HashSet<WorkQueueEmailBody>();
            WorkQueueMessageLastUpdUserNavigations = new HashSet<WorkQueueMessage>();
            WorkQueueMessageLogs = new HashSet<WorkQueueMessageLog>();
            WorkQueueMessageUserCreatedNavigations = new HashSet<WorkQueueMessage>();
            WorkQueueUserXrefs = new HashSet<WorkQueueUserXref>();
            WorkflowCreationUsers = new HashSet<Workflow>();
            WorkflowStatusChgUsers = new HashSet<Workflow>();
            Profiles = new HashSet<Profile>();
        }

        public int EmployeeId { get; set; }
        public int ClassTypeId { get; set; }
        public int? HomeOfficeId { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? LoginName { get; set; }
        public int StatusCd { get; set; }
        public string Initials { get; set; } = null!;
        public string? PersonnelCd { get; set; }
        public string? TitleLine1 { get; set; }
        public string? TitleLine2 { get; set; }
        public string? TitleLine3 { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public short? OfficeGroupFlag { get; set; }
        public short? HighlightSignaturesOption { get; set; }
        public byte? IsContractorOrTemporary { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? SymantecLoginName { get; set; }
        public decimal? EmployeeOverDraftAmt { get; set; }
        public string? UwliabilityLimit { get; set; }
        public string? SignatureFile { get; set; }
        public short UwemailNotify { get; set; }

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual BusinessUnit? HomeOffice { get; set; }
        public virtual CustomerPreference? CustomerPreference { get; set; }
        public virtual ICollection<AccountingPrivacyEventLog> AccountingPrivacyEventLogs { get; set; }
        public virtual ICollection<AddrBookEntry> AddrBookEntryCreationEmployees { get; set; }
        public virtual ICollection<AddrBookEntry> AddrBookEntryStatusChgEmployees { get; set; }
        public virtual ICollection<AgentNetValidationRequestStatus> AgentNetValidationRequestStatuses { get; set; }
        public virtual ICollection<AlternateBankChangeHistory> AlternateBankChangeHistories { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<BusOrgContactRelationshipChangeHistory> BusOrgContactRelationshipChangeHistories { get; set; }
        public virtual ICollection<BusOrgContact> BusOrgContacts { get; set; }
        public virtual ICollection<BusOrgRelationshipChangeHistory> BusOrgRelationshipChangeHistories { get; set; }
        public virtual ICollection<BusOrg> BusOrgs { get; set; }
        public virtual ICollection<BusinessProgramBusOrgChangeHistory> BusinessProgramBusOrgChangeHistories { get; set; }
        public virtual ICollection<BusinessProgramBusOrgContactChangeHistory> BusinessProgramBusOrgContactChangeHistories { get; set; }
        public virtual ICollection<BusinessProgramBusUnitChangeHistory> BusinessProgramBusUnitChangeHistories { get; set; }
        public virtual ICollection<BusinessSourceType> BusinessSourceTypeCreationEmployees { get; set; }
        public virtual ICollection<BusinessSourceType> BusinessSourceTypeStatusChgUsers { get; set; }
        public virtual ICollection<BusinessSourceType> BusinessSourceTypeUpdatedEmployees { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitCreationUsers { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitStatusChgUsers { get; set; }
        public virtual ICollection<ChangeOwningOfficeHistory> ChangeOwningOfficeHistories { get; set; }
        public virtual ICollection<Charge> ChargeCreationEmployees { get; set; }
        public virtual ICollection<ChargeResequence> ChargeResequenceCreationUsers { get; set; }
        public virtual ICollection<ChargeResequence> ChargeResequenceLastModifiedUsers { get; set; }
        public virtual ICollection<Charge> ChargeUpdatedEmployees { get; set; }
        public virtual ICollection<CorpCpuproductionOffice> CorpCpuproductionOfficeCreatedUsers { get; set; }
        public virtual ICollection<CorpCpuproductionOffice> CorpCpuproductionOfficeModifiedUsers { get; set; }
        public virtual ICollection<DeliveryEventLog> DeliveryEventLogs { get; set; }
        public virtual ICollection<DepositList> DepositLists { get; set; }
        public virtual ICollection<Disbursement> DisbursementHeldByEmployees { get; set; }
        public virtual ICollection<Disbursement> DisbursementIssuedByEmployees { get; set; }
        public virtual ICollection<Disbursement> DisbursementReleasedByEmployees { get; set; }
        public virtual ICollection<Disbursement> DisbursementSplitByEmployees { get; set; }
        public virtual ICollection<Docphrase> Docphrases { get; set; }
        public virtual ICollection<DocumentLicenseInfo> DocumentLicenseInfoFinalizedEmployees { get; set; }
        public virtual ICollection<DocumentLicenseInfo> DocumentLicenseInfoLicensedEmployees { get; set; }
        public virtual ICollection<DocumentLicenseInfo> DocumentLicenseInfoRequestedEmployees { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<EbusinessRequest> EbusinessRequests { get; set; }
        public virtual ICollection<EcheckDetail> EcheckDetails { get; set; }
        public virtual ICollection<EmployedBy> EmployedByCreationEmployees { get; set; }
        public virtual ICollection<EmployedBy> EmployedByStatusChgUsers { get; set; }
        public virtual ICollection<EmployedBy> EmployedByUpdatedEmployees { get; set; }
        public virtual ICollection<EmployeeFunctionXref> EmployeeFunctionXrefs { get; set; }
        public virtual ICollection<EmployeeNotificationPref> EmployeeNotificationPrefs { get; set; }
        public virtual ICollection<EmployeeOverdraftEmailOptOutList> EmployeeOverdraftEmailOptOutLists { get; set; }
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistoryEmployees { get; set; }
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistoryUsers { get; set; }
        public virtual ICollection<EmployeeWorkgroupXref> EmployeeWorkgroupXrefs { get; set; }
        public virtual ICollection<Event> EventCreationUsers { get; set; }
        public virtual ICollection<Event> EventStatusChgUsers { get; set; }
        public virtual ICollection<FaccclosingCost> FaccclosingCosts { get; set; }
        public virtual ICollection<Faccendorsement> Faccendorsements { get; set; }
        public virtual ICollection<FaccrecordingFee> FaccrecordingFees { get; set; }
        public virtual ICollection<FacctitlePolicy> FacctitlePolicies { get; set; }
        public virtual ICollection<FaxGroup> FaxGroups { get; set; }
        public virtual ICollection<FeeFilterTemplate> FeeFilterTemplateCreatedUsers { get; set; }
        public virtual ICollection<FeeFilterTemplate> FeeFilterTemplateStatusChgUsers { get; set; }
        public virtual ICollection<FeeSetupChangeHistory> FeeSetupChangeHistories { get; set; }
        public virtual ICollection<FftchangeHistory> FftchangeHistories { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartySales1Employees { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartySales2Employees { get; set; }
        public virtual ICollection<FileProcess> FileProcessCreationEmployees { get; set; }
        public virtual ICollection<FileProcess> FileProcessUpdatedEmployees { get; set; }
        public virtual ICollection<FileServiceProductionOfficeXref> FileServiceProductionOfficeXrefAssistants { get; set; }
        public virtual ICollection<FileServiceProductionOfficeXref> FileServiceProductionOfficeXrefOfficers { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueLockedByUsers { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueRequestors { get; set; }
        public virtual ICollection<GenericEmail> GenericEmails { get; set; }
        public virtual ICollection<GroupResequence> GroupResequenceCreationUsers { get; set; }
        public virtual ICollection<GroupResequence> GroupResequenceLastModifiedUsers { get; set; }
        public virtual ICollection<HudDeliveryVersioning> HudDeliveryVersionings { get; set; }
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<IbabankBranch> IbabankBranchCreationEmployees { get; set; }
        public virtual ICollection<IbabankBranch> IbabankBranchCurrStatusUsers { get; set; }
        public virtual ICollection<IbabankProduct> IbabankProducts { get; set; }
        public virtual ICollection<IbabankStatusChangeXref> IbabankStatusChangeXrefs { get; set; }
        public virtual ICollection<IbatransactionAdjustmentLog> IbatransactionAdjustmentLogs { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositCreationEmployees { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositExcludeEmployees { get; set; }
        public virtual ICollection<IncomingWireDetail> IncomingWireDetails { get; set; }
        public virtual ICollection<IncomingWireDisbursement> IncomingWireDisbursements { get; set; }
        public virtual ICollection<Instruction> InstructionCreationEmployees { get; set; }
        public virtual ICollection<Instruction> InstructionStatusChangeUsers { get; set; }
        public virtual ICollection<Instruction> InstructionUpdatedEmployees { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequests { get; set; }
        public virtual ICollection<InvoiceHistory> InvoiceHistoryEscrowOfficers { get; set; }
        public virtual ICollection<InvoiceHistory> InvoiceHistoryTitleOfficers { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<LicenseInformation> LicenseInformationCreationUsers { get; set; }
        public virtual ICollection<LicenseInformation> LicenseInformationDeActivationByNavigations { get; set; }
        public virtual ICollection<LicenseInformationLog> LicenseInformationLogs { get; set; }
        public virtual ICollection<LicenseInformation> LicenseInformationReActivationByNavigations { get; set; }
        public virtual ICollection<LicenseTypeGeoRegionXref> LicenseTypeGeoRegionXrefCreationUsers { get; set; }
        public virtual ICollection<LicenseTypeGeoRegionXref> LicenseTypeGeoRegionXrefDeactivationUsers { get; set; }
        public virtual ICollection<LicenseTypeGeoRegionXref> LicenseTypeGeoRegionXrefReactivationUsers { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplateCreatedUsers { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplateStatusChgUsers { get; set; }
        public virtual ICollection<OfficeUnderwriter> OfficeUnderwriterCreationEmployees { get; set; }
        public virtual ICollection<OfficeUnderwriter> OfficeUnderwriterStatusChgUsers { get; set; }
        public virtual ICollection<OfficeUnderwriter> OfficeUnderwriterUpdatedEmployees { get; set; }
        public virtual ICollection<PersonBpchangeHistory> PersonBpchangeHistories { get; set; }
        public virtual ICollection<PersonRelationshipChangeHistory> PersonRelationshipChangeHistories { get; set; }
        public virtual ICollection<Person> PersonSalesRep1Navigations { get; set; }
        public virtual ICollection<Person> PersonSalesRep2Navigations { get; set; }
        public virtual ICollection<Phrase> PhraseCreationUsers { get; set; }
        public virtual ICollection<PhraseHistory> PhraseHistories { get; set; }
        public virtual ICollection<PhraseMarkerFormVersion> PhraseMarkerFormVersions { get; set; }
        public virtual ICollection<PhraseMarkerForm> PhraseMarkerForms { get; set; }
        public virtual ICollection<Phrase> PhraseStatusChgUsers { get; set; }
        public virtual ICollection<PreferredBusOrgContactXref> PreferredBusOrgContactXrefs { get; set; }
        public virtual ICollection<PreferredEmployeeContactXref> PreferredEmployeeContactXrefs { get; set; }
        public virtual ICollection<PreferredPersonXref> PreferredPersonXrefs { get; set; }
        public virtual ICollection<PrintPreference> PrintPreferences { get; set; }
        public virtual ICollection<ProfileChangeHistory> ProfileChangeHistories { get; set; }
        public virtual ICollection<QcstagingSectionCharge> QcstagingSectionCharges { get; set; }
        public virtual ICollection<QcstagingSectionXref> QcstagingSectionXrefs { get; set; }
        public virtual ICollection<RegionUnderwriter> RegionUnderwriterCreationEmployees { get; set; }
        public virtual ICollection<RegionUnderwriter> RegionUnderwriterStatusChgUsers { get; set; }
        public virtual ICollection<RegionUnderwriter> RegionUnderwriterUpdatedEmployees { get; set; }
        public virtual ICollection<ReserveFileUsed> ReserveFileUseds { get; set; }
        public virtual ICollection<ReserveFile> ReserveFiles { get; set; }
        public virtual ICollection<RoleChangeHistory> RoleChangeHistories { get; set; }
        public virtual ICollection<RuleList> RuleListCreatedByNavigations { get; set; }
        public virtual ICollection<RuleList> RuleListDeActivationByNavigations { get; set; }
        public virtual ICollection<RuleList> RuleListLastUpdatedByNavigations { get; set; }
        public virtual ICollection<RuleList> RuleListReActivationByNavigations { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistoryFromSalesRepId1Navigations { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistoryFromSalesRepId2Navigations { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistoryToSalesRepId1Navigations { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistoryToSalesRepId2Navigations { get; set; }
        public virtual ICollection<SecOffcGrpChangeHistory> SecOffcGrpChangeHistories { get; set; }
        public virtual ICollection<SectionResequence> SectionResequenceCreationUsers { get; set; }
        public virtual ICollection<SectionResequence> SectionResequenceLastModifiedUsers { get; set; }
        public virtual ICollection<ServiceFile> ServiceFileCreationUsers { get; set; }
        public virtual ICollection<ServiceFileEmployeeXref> ServiceFileEmployeeXrefs { get; set; }
        public virtual ICollection<ServiceFileNote> ServiceFileNoteCreationEmployees { get; set; }
        public virtual ICollection<ServiceFileNote> ServiceFileNoteUpdatedEmployees { get; set; }
        public virtual ICollection<ServiceFile> ServiceFileSalesReps { get; set; }
        public virtual ICollection<ServiceFile> ServiceFileStatusChgUsers { get; set; }
        public virtual ICollection<SigningParty> SigningParties { get; set; }
        public virtual ICollection<Signing> Signings { get; set; }
        public virtual ICollection<SolrUserFavoriteCustomer> SolrUserFavoriteCustomers { get; set; }
        public virtual ICollection<SymentecVipauditLog> SymentecVipauditLogs { get; set; }
        public virtual ICollection<TaskCategory> TaskCategories { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessPartySales1Employees { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessPartySales2Employees { get; set; }
        public virtual ICollection<Template> TemplateCreationUsers { get; set; }
        public virtual ICollection<TemplateHistory> TemplateHistories { get; set; }
        public virtual ICollection<Template> TemplateStatusChgUsers { get; set; }
        public virtual ICollection<ThresholdAmountChangeHistory> ThresholdAmountChangeHistories { get; set; }
        public virtual ICollection<UserBusUnitXref> UserBusUnitXrefs { get; set; }
        public virtual ICollection<UserFavorite> UserFavorites { get; set; }
        public virtual ICollection<UserGuipreference> UserGuipreferences { get; set; }
        public virtual ICollection<UserSecOffcGrpXref> UserSecOffcGrpXrefs { get; set; }
        public virtual ICollection<VendorInfo> VendorInfos { get; set; }
        public virtual ICollection<WorkFlowTemplateChangeHistory> WorkFlowTemplateChangeHistories { get; set; }
        public virtual ICollection<WorkFlowTemplate> WorkFlowTemplates { get; set; }
        public virtual ICollection<WorkGroup> WorkGroupCreationUsers { get; set; }
        public virtual ICollection<WorkGroup> WorkGroupStatusChgUsers { get; set; }
        public virtual ICollection<WorkQueueEmailBody> WorkQueueEmailBodies { get; set; }
        public virtual ICollection<WorkQueueMessage> WorkQueueMessageLastUpdUserNavigations { get; set; }
        public virtual ICollection<WorkQueueMessageLog> WorkQueueMessageLogs { get; set; }
        public virtual ICollection<WorkQueueMessage> WorkQueueMessageUserCreatedNavigations { get; set; }
        public virtual ICollection<WorkQueueUserXref> WorkQueueUserXrefs { get; set; }
        public virtual ICollection<Workflow> WorkflowCreationUsers { get; set; }
        public virtual ICollection<Workflow> WorkflowStatusChgUsers { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
