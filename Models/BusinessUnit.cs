using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessUnit
    {
        public BusinessUnit()
        {
            BankAccounts = new HashSet<BankAccount>();
            BankBranches = new HashSet<BankBranch>();
            BuproductionOfficeXrefBusinessUnits = new HashSet<BuproductionOfficeXref>();
            BuproductionOfficeXrefProductionOffices = new HashSet<BuproductionOfficeXref>();
            BusOrgAgentOffices = new HashSet<BusOrg>();
            BusOrgBusinessUnits = new HashSet<BusOrg>();
            BusUnitAutoNumbers = new HashSet<BusUnitAutoNumber>();
            BusUnitStampImages = new HashSet<BusUnitStampImage>();
            BusinessProgramBusUnitChangeHistories = new HashSet<BusinessProgramBusUnitChangeHistory>();
            BusinessSourceTypes = new HashSet<BusinessSourceType>();
            BusinessUnitXrefs = new HashSet<BusinessUnitXref>();
            ChangeOwningOfficeHistoryNewOwnerOffices = new HashSet<ChangeOwningOfficeHistory>();
            ChangeOwningOfficeHistoryOldOwnerOffices = new HashSet<ChangeOwningOfficeHistory>();
            CopyToDocPrefs = new HashSet<CopyToDocPref>();
            CountyInfoDefaultOwnerOffices = new HashSet<CountyInfo>();
            CountyInfoDefaultProductionOffices = new HashSet<CountyInfo>();
            DepositLists = new HashSet<DepositList>();
            EmployedBies = new HashSet<EmployedBy>();
            EmployeeSecurityChangeHistories = new HashSet<EmployeeSecurityChangeHistory>();
            Employees = new HashSet<Employee>();
            EscrowChargeTemplates = new HashSet<EscrowChargeTemplate>();
            EsigningCredentials = new HashSet<EsigningCredential>();
            EtitleBusinessUnits = new HashSet<EtitleBusinessUnit>();
            ExternalBusinessUnitXrefs = new HashSet<ExternalBusinessUnitXref>();
            FaxGroups = new HashSet<FaxGroup>();
            FeeFilterTemplates = new HashSet<FeeFilterTemplate>();
            Fees = new HashSet<Fee>();
            FileBusinessPartyAgentOffices = new HashSet<FileBusinessParty>();
            FileBusinessPartyBusinessUnits = new HashSet<FileBusinessParty>();
            FileServiceProductionOfficeXrefs = new HashSet<FileServiceProductionOfficeXref>();
            FileServices = new HashSet<FileService>();
            FormDocuments = new HashSet<FormDocument>();
            FormTemplates = new HashSet<FormTemplate>();
            GabentryRequestQueues = new HashSet<GabentryRequestQueue>();
            Gllookups = new HashSet<Gllookup>();
            GuinodeCustomizations = new HashSet<GuinodeCustomization>();
            IbabankBranches = new HashSet<IbabankBranch>();
            InstructionOptionBusUnitXrefs = new HashSet<InstructionOptionBusUnitXref>();
            Instructions = new HashSet<Instruction>();
            InterfaceDeliveryRequestBusUnits = new HashSet<InterfaceDeliveryRequest>();
            InterfaceDeliveryRequestRegions = new HashSet<InterfaceDeliveryRequest>();
            InverseEscrowProdOffice = new HashSet<BusinessUnit>();
            InverseSuperBusinessUnit = new HashSet<BusinessUnit>();
            InverseTitleProdOffice = new HashSet<BusinessUnit>();
            InvoiceHistoryEscrowOwningOffices = new HashSet<InvoiceHistory>();
            InvoiceHistoryTitleOwningOffices = new HashSet<InvoiceHistory>();
            OfficeGroups = new HashSet<OfficeGroup>();
            OfficePrinterPrefrences = new HashSet<OfficePrinterPrefrence>();
            OfficeProductChangeHistories = new HashSet<OfficeProductChangeHistory>();
            OfficeUnderwriters = new HashSet<OfficeUnderwriter>();
            PhraseGeoRegionFilterDocpreps = new HashSet<PhraseGeoRegionFilterDocprep>();
            PhraseGeoRegionFilters = new HashSet<PhraseGeoRegionFilter>();
            PhraseGrpGeoRegionfilters = new HashSet<PhraseGrpGeoRegionfilter>();
            PhraseGrpRegionFilterDocpreps = new HashSet<PhraseGrpRegionFilterDocprep>();
            PhraseGrps = new HashSet<PhraseGrp>();
            PhraseMarkerForms = new HashSet<PhraseMarkerForm>();
            ProductTypeBusUnitXrefs = new HashSet<ProductTypeBusUnitXref>();
            ProfileBusUnitXrefs = new HashSet<ProfileBusUnitXref>();
            ProfileChangeHistories = new HashSet<ProfileChangeHistory>();
            Profiles = new HashSet<Profile>();
            RegionProblemLogXrefs = new HashSet<RegionProblemLogXref>();
            RegionUnderwriters = new HashSet<RegionUnderwriter>();
            RegionalDeliveryDestinationCpuproductionOffices = new HashSet<RegionalDeliveryDestination>();
            RegionalDeliveryDestinationRegions = new HashSet<RegionalDeliveryDestination>();
            ReserveFileOffices = new HashSet<ReserveFile>();
            ReserveFileRegions = new HashSet<ReserveFile>();
            RoleVisibilityXrefs = new HashSet<RoleVisibilityXref>();
            Rtmaddresses = new HashSet<Rtmaddress>();
            RuleListBusUnitXrefs = new HashSet<RuleListBusUnitXref>();
            RuleLists = new HashSet<RuleList>();
            SecOffcGrpChangeHistories = new HashSet<SecOffcGrpChangeHistory>();
            SecOfficeGroupsNavigation = new HashSet<SecOfficeGroup>();
            ServiceFileUnderwriterXrefs = new HashSet<ServiceFileUnderwriterXref>();
            ServiceFiles = new HashSet<ServiceFile>();
            SigningAddrXrefs = new HashSet<SigningAddrXref>();
            TaskCategories = new HashSet<TaskCategory>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
            TemplateFilterGrpDocPreps = new HashSet<TemplateFilterGrpDocPrep>();
            TemplateFilterGrps = new HashSet<TemplateFilterGrp>();
            TemplateFilterOwningRegionXrefDocPreps = new HashSet<TemplateFilterOwningRegionXrefDocPrep>();
            TemplateFilterOwningRegionXrefs = new HashSet<TemplateFilterOwningRegionXref>();
            TemplateValidationByRegionDocpreps = new HashSet<TemplateValidationByRegionDocprep>();
            Templates = new HashSet<Template>();
            UndeliveredEmailDetails = new HashSet<UndeliveredEmailDetail>();
            UserBusUnitXrefs = new HashSet<UserBusUnitXref>();
            WorkFlowTemplateBusinessUnits = new HashSet<WorkFlowTemplate>();
            WorkFlowTemplateProcessOwnerRegions = new HashSet<WorkFlowTemplate>();
            WorkQueueTriggerXrefs = new HashSet<WorkQueueTriggerXref>();
            WorkQueueTriggers = new HashSet<WorkQueueTrigger>();
            Workflow2s = new HashSet<Workflow2>();
            Workflows = new HashSet<Workflow>();
            ActivityGrps = new HashSet<ActivityGrp>();
            Appls = new HashSet<Application>();
            BankAccts = new HashSet<BankAccount>();
            BusinessPrograms = new HashSet<BusinessProgram>();
            CorporateBusOrgs = new HashSet<CorporateBusOrg>();
            OfficeGroupsNavigation = new HashSet<OfficeGroup>();
            SecOfficeGroups = new HashSet<SecOfficeGroup>();
            TaskTemplates = new HashSet<TaskTemplate>();
            WorkQueues = new HashSet<WorkQueue>();
            Workgroups = new HashSet<WorkGroup>();
        }

        public int BusinessUnitId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int? SuperBusinessUnitId { get; set; }
        public int? FeeTransmittalType { get; set; }
        public int? EscrowProdOfficeId { get; set; }
        public int? TitleProdOfficeId { get; set; }
        public int StatusCd { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string Name { get; set; } = null!;
        public string? LogoFileName { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? TrustNetRegionCd { get; set; }
        public string? TrustNetOfficePrefix { get; set; }
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public int? SiteId { get; set; }
        public decimal? OverDraftAmt { get; set; }
        public string? OverDraftPwd { get; set; }
        public string? LogoFileName2 { get; set; }
        public string? LogoFileName3 { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TimeZoneTypeCdId { get; set; }
        public short? TimeZoneDayLightFlag { get; set; }
        public string? AccountingFtpIp { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? RemoteDirectory { get; set; }
        public short? InvoiceEstimateFlag { get; set; }
        public int? RecFeeTemplateBusinessPartyId { get; set; }
        public int? TransferTaxesTemplateBusinessPartyId { get; set; }
        public int? BusSegTypeCdId { get; set; }
        public string? GlclientCode { get; set; }
        public string? GldivisionCode { get; set; }
        public short? PromulgatedFeeDisplayFlag { get; set; }
        public short BulkMailFlag { get; set; }
        public string? SystemDocumentLogoFile { get; set; }
        public string? FastStatCode { get; set; }
        public int? TitleAgentTypeCdId { get; set; }
        public short? ProductionOfficeFlag { get; set; }
        public short? TestOnlyFlag { get; set; }
        public short? DuplicateCheckFlag { get; set; }
        public string? Division { get; set; }
        public string? LineOfBus { get; set; }
        public string? RecipientType { get; set; }
        public string? RecipientId { get; set; }
        public DateTime? Sms1099sActivityDate { get; set; }
        public short? ProductionCenterFlag { get; set; }
        public byte? AccountServiceFlag { get; set; }
        public short DateDownFlag { get; set; }
        public byte? Pdcflag { get; set; }
        public short FispayoffDemandFlag { get; set; }
        public short? NpsproductionOfficeFlag { get; set; }
        public int? ReportingOffTypeCdId { get; set; }
        public int? ProdSystemTypeCdId { get; set; }
        public string? ClientIpaddress { get; set; }
        public string? ClientNetworkDomain { get; set; }
        public short? SigningFlag { get; set; }
        public short? DisplayInQfeflag { get; set; }
        public short? DisplayInBuyerFlag { get; set; }
        public short? DisplayInSellerFlag { get; set; }
        public string? ExtractCutoffTime { get; set; }
        public string? ExtractFailureAlertRecipientEmail { get; set; }
        public byte? IsAgentRegion { get; set; }
        public short UploadWordExcelFlag { get; set; }
        public int? CorpParentTypeCdId { get; set; }
        public short? ExceptionOfficeFlag { get; set; }
        public short? TrialBalanceNoteFlag { get; set; }
        public byte? IsMdmconverted { get; set; }
        public short? EtitleDeliveryFlag { get; set; }
        public short? ProjectFileFlag { get; set; }
        public DateTime? NextGenDocPrepLaunchDate { get; set; }
        public short? ExchangeRegionFlag { get; set; }
        public int? ExchangeOfficeTypeCdId { get; set; }
        public short? CorpSymantecWireApprovalFlag { get; set; }
        public short? SymantecWireApprovalFlag { get; set; }
        public short? AgentNetPolicyNumberFlag { get; set; }
        public short? InfodexLinkFlag { get; set; }
        public string? InfodexUrl { get; set; }
        public short Mfaflag { get; set; }
        public short? DepositLossRecoveryFlag { get; set; }
        public string? OperationOpenTime { get; set; }
        public string? OperationCloseTime { get; set; }
        public short? DisplaySubordinationScreenFlag { get; set; }
        public short? EnableCdflag { get; set; }
        public int? BusUnitTypeCdId { get; set; }
        public int? PolicyIssuedByTypeCdId { get; set; }
        public short? Ncsssflag { get; set; }
        public byte? FaccclosingCostFlag { get; set; }
        public int? SolrSearchTypeCdId { get; set; }
        public byte EmployeeOverDraftLimit { get; set; }
        public short? LenderUpdatesEmailNotificationFlag { get; set; }
        public short? OverwriteNextGenFlag { get; set; }
        public bool IsFileNotesSortingDesc { get; set; }
        public short? LaunchFastSearchOnOpenOrder { get; set; }
        public bool HiddenOfficeFlag { get; set; }
        public byte AllowLockingDisbursements { get; set; }
        public bool IsOverdraftSettings { get; set; }
        public bool IsSecureMessagingEnabled { get; set; }
        public bool IsEnableTaskChecklist { get; set; }
        public int? SafeValidationTypeCdId { get; set; }
        public DateTime? OfficeEffectiveDate { get; set; }
        public DateTime? OfficeCloseDate { get; set; }
        public bool? IsEmployeeOverdraftSelfApproval { get; set; }
        public byte? IsAgentUserEmail { get; set; }
        public bool? IsAgentRegionExcluded { get; set; }

        public virtual AddrBookEntry? AddrBookEntry { get; set; }
        public virtual TypeCdDmt? BusUnitTypeCd { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual BusinessUnit? EscrowProdOffice { get; set; }
        public virtual TypeCdDmt? ExchangeOfficeTypeCd { get; set; }
        public virtual TypeCdDmt? PolicyIssuedByTypeCd { get; set; }
        public virtual TypeCdDmt? ProdSystemTypeCd { get; set; }
        public virtual TemplateBusinessParty? RecFeeTemplateBusinessParty { get; set; }
        public virtual TypeCdDmt? ReportingOffTypeCd { get; set; }
        public virtual TypeCdDmt? SolrSearchTypeCd { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual BusinessUnit? SuperBusinessUnit { get; set; }
        public virtual TypeCdDmt? TitleAgentTypeCd { get; set; }
        public virtual BusinessUnit? TitleProdOffice { get; set; }
        public virtual TemplateBusinessParty? TransferTaxesTemplateBusinessParty { get; set; }
        public virtual BusUnitAcctSystemXref? BusUnitAcctSystemXref { get; set; }
        public virtual BusinessunitsForDailyEmailstatus? BusinessunitsForDailyEmailstatus { get; set; }
        public virtual CorpCpuproductionOffice? CorpCpuproductionOffice { get; set; }
        public virtual OfficesForFastc? OfficesForFastc { get; set; }
        public virtual RegionIdforApplication? RegionIdforApplication { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<BankBranch> BankBranches { get; set; }
        public virtual ICollection<BuproductionOfficeXref> BuproductionOfficeXrefBusinessUnits { get; set; }
        public virtual ICollection<BuproductionOfficeXref> BuproductionOfficeXrefProductionOffices { get; set; }
        public virtual ICollection<BusOrg> BusOrgAgentOffices { get; set; }
        public virtual ICollection<BusOrg> BusOrgBusinessUnits { get; set; }
        public virtual ICollection<BusUnitAutoNumber> BusUnitAutoNumbers { get; set; }
        public virtual ICollection<BusUnitStampImage> BusUnitStampImages { get; set; }
        public virtual ICollection<BusinessProgramBusUnitChangeHistory> BusinessProgramBusUnitChangeHistories { get; set; }
        public virtual ICollection<BusinessSourceType> BusinessSourceTypes { get; set; }
        public virtual ICollection<BusinessUnitXref> BusinessUnitXrefs { get; set; }
        public virtual ICollection<ChangeOwningOfficeHistory> ChangeOwningOfficeHistoryNewOwnerOffices { get; set; }
        public virtual ICollection<ChangeOwningOfficeHistory> ChangeOwningOfficeHistoryOldOwnerOffices { get; set; }
        public virtual ICollection<CopyToDocPref> CopyToDocPrefs { get; set; }
        public virtual ICollection<CountyInfo> CountyInfoDefaultOwnerOffices { get; set; }
        public virtual ICollection<CountyInfo> CountyInfoDefaultProductionOffices { get; set; }
        public virtual ICollection<DepositList> DepositLists { get; set; }
        public virtual ICollection<EmployedBy> EmployedBies { get; set; }
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplates { get; set; }
        public virtual ICollection<EsigningCredential> EsigningCredentials { get; set; }
        public virtual ICollection<EtitleBusinessUnit> EtitleBusinessUnits { get; set; }
        public virtual ICollection<ExternalBusinessUnitXref> ExternalBusinessUnitXrefs { get; set; }
        public virtual ICollection<FaxGroup> FaxGroups { get; set; }
        public virtual ICollection<FeeFilterTemplate> FeeFilterTemplates { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartyAgentOffices { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartyBusinessUnits { get; set; }
        public virtual ICollection<FileServiceProductionOfficeXref> FileServiceProductionOfficeXrefs { get; set; }
        public virtual ICollection<FileService> FileServices { get; set; }
        public virtual ICollection<FormDocument> FormDocuments { get; set; }
        public virtual ICollection<FormTemplate> FormTemplates { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueues { get; set; }
        public virtual ICollection<Gllookup> Gllookups { get; set; }
        public virtual ICollection<GuinodeCustomization> GuinodeCustomizations { get; set; }
        public virtual ICollection<IbabankBranch> IbabankBranches { get; set; }
        public virtual ICollection<InstructionOptionBusUnitXref> InstructionOptionBusUnitXrefs { get; set; }
        public virtual ICollection<Instruction> Instructions { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequestBusUnits { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequestRegions { get; set; }
        public virtual ICollection<BusinessUnit> InverseEscrowProdOffice { get; set; }
        public virtual ICollection<BusinessUnit> InverseSuperBusinessUnit { get; set; }
        public virtual ICollection<BusinessUnit> InverseTitleProdOffice { get; set; }
        public virtual ICollection<InvoiceHistory> InvoiceHistoryEscrowOwningOffices { get; set; }
        public virtual ICollection<InvoiceHistory> InvoiceHistoryTitleOwningOffices { get; set; }
        public virtual ICollection<OfficeGroup> OfficeGroups { get; set; }
        public virtual ICollection<OfficePrinterPrefrence> OfficePrinterPrefrences { get; set; }
        public virtual ICollection<OfficeProductChangeHistory> OfficeProductChangeHistories { get; set; }
        public virtual ICollection<OfficeUnderwriter> OfficeUnderwriters { get; set; }
        public virtual ICollection<PhraseGeoRegionFilterDocprep> PhraseGeoRegionFilterDocpreps { get; set; }
        public virtual ICollection<PhraseGeoRegionFilter> PhraseGeoRegionFilters { get; set; }
        public virtual ICollection<PhraseGrpGeoRegionfilter> PhraseGrpGeoRegionfilters { get; set; }
        public virtual ICollection<PhraseGrpRegionFilterDocprep> PhraseGrpRegionFilterDocpreps { get; set; }
        public virtual ICollection<PhraseGrp> PhraseGrps { get; set; }
        public virtual ICollection<PhraseMarkerForm> PhraseMarkerForms { get; set; }
        public virtual ICollection<ProductTypeBusUnitXref> ProductTypeBusUnitXrefs { get; set; }
        public virtual ICollection<ProfileBusUnitXref> ProfileBusUnitXrefs { get; set; }
        public virtual ICollection<ProfileChangeHistory> ProfileChangeHistories { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<RegionProblemLogXref> RegionProblemLogXrefs { get; set; }
        public virtual ICollection<RegionUnderwriter> RegionUnderwriters { get; set; }
        public virtual ICollection<RegionalDeliveryDestination> RegionalDeliveryDestinationCpuproductionOffices { get; set; }
        public virtual ICollection<RegionalDeliveryDestination> RegionalDeliveryDestinationRegions { get; set; }
        public virtual ICollection<ReserveFile> ReserveFileOffices { get; set; }
        public virtual ICollection<ReserveFile> ReserveFileRegions { get; set; }
        public virtual ICollection<RoleVisibilityXref> RoleVisibilityXrefs { get; set; }
        public virtual ICollection<Rtmaddress> Rtmaddresses { get; set; }
        public virtual ICollection<RuleListBusUnitXref> RuleListBusUnitXrefs { get; set; }
        public virtual ICollection<RuleList> RuleLists { get; set; }
        public virtual ICollection<SecOffcGrpChangeHistory> SecOffcGrpChangeHistories { get; set; }
        public virtual ICollection<SecOfficeGroup> SecOfficeGroupsNavigation { get; set; }
        public virtual ICollection<ServiceFileUnderwriterXref> ServiceFileUnderwriterXrefs { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
        public virtual ICollection<SigningAddrXref> SigningAddrXrefs { get; set; }
        public virtual ICollection<TaskCategory> TaskCategories { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }
        public virtual ICollection<TemplateFilterGrpDocPrep> TemplateFilterGrpDocPreps { get; set; }
        public virtual ICollection<TemplateFilterGrp> TemplateFilterGrps { get; set; }
        public virtual ICollection<TemplateFilterOwningRegionXrefDocPrep> TemplateFilterOwningRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterOwningRegionXref> TemplateFilterOwningRegionXrefs { get; set; }
        public virtual ICollection<TemplateValidationByRegionDocprep> TemplateValidationByRegionDocpreps { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public virtual ICollection<UndeliveredEmailDetail> UndeliveredEmailDetails { get; set; }
        public virtual ICollection<UserBusUnitXref> UserBusUnitXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplate> WorkFlowTemplateBusinessUnits { get; set; }
        public virtual ICollection<WorkFlowTemplate> WorkFlowTemplateProcessOwnerRegions { get; set; }
        public virtual ICollection<WorkQueueTriggerXref> WorkQueueTriggerXrefs { get; set; }
        public virtual ICollection<WorkQueueTrigger> WorkQueueTriggers { get; set; }
        public virtual ICollection<Workflow2> Workflow2s { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }

        public virtual ICollection<ActivityGrp> ActivityGrps { get; set; }
        public virtual ICollection<Application> Appls { get; set; }
        public virtual ICollection<BankAccount> BankAccts { get; set; }
        public virtual ICollection<BusinessProgram> BusinessPrograms { get; set; }
        public virtual ICollection<CorporateBusOrg> CorporateBusOrgs { get; set; }
        public virtual ICollection<OfficeGroup> OfficeGroupsNavigation { get; set; }
        public virtual ICollection<SecOfficeGroup> SecOfficeGroups { get; set; }
        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
        public virtual ICollection<WorkQueue> WorkQueues { get; set; }
        public virtual ICollection<WorkGroup> Workgroups { get; set; }
    }
}
