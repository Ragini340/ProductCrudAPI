using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFile
    {
        public ServiceFile()
        {
            AccountingPrivacyEventLogs = new HashSet<AccountingPrivacyEventLog>();
            AgentNetPolicyNumbers = new HashSet<AgentNetPolicyNumber>();
            AgentNetRemittanceCplFees = new HashSet<AgentNetRemittanceCplFee>();
            ArchiveTrackings = new HashSet<ArchiveTracking>();
            ChangeOwningOfficeHistories = new HashSet<ChangeOwningOfficeHistory>();
            ChargeResequences = new HashSet<ChargeResequence>();
            Charges = new HashSet<Charge>();
            ClosingDisclosureEventLogs = new HashSet<ClosingDisclosureEventLog>();
            ClosingDisclosures = new HashSet<ClosingDisclosure>();
            CoInsuranceLiabilities = new HashSet<CoInsuranceLiability>();
            CopyDocsRequestSourceFiles = new HashSet<CopyDocsRequest>();
            CopyDocsRequestTargetFiles = new HashSet<CopyDocsRequest>();
            DeliveryEventLogs = new HashSet<DeliveryEventLog>();
            Disbursements = new HashSet<Disbursement>();
            DocDetailsImageDocTools = new HashSet<DocDetailsImageDocTool>();
            DocumentGridFileAndScreenGridFilters = new HashSet<DocumentGridFileAndScreenGridFilter>();
            DocumentPackages = new HashSet<DocumentPackage>();
            Documents = new HashSet<Document>();
            EsigningDashboardDetails = new HashSet<EsigningDashboardDetail>();
            EventLogOes = new HashSet<EventLogOe>();
            ExternalFileServices = new HashSet<ExternalFileService>();
            Faccrequestlogs = new HashSet<Faccrequestlog>();
            Fast1099sDetails = new HashSet<Fast1099sDetail>();
            Fast1099sHeaders = new HashSet<Fast1099sHeader>();
            FastSearchLogs = new HashSet<FastSearchLog>();
            FastSearchResults = new HashSet<FastSearchResult>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            FileProcesses = new HashSet<FileProcess>();
            FileServices = new HashSet<FileService>();
            FloridaDisclosureOverrideNames = new HashSet<FloridaDisclosureOverrideName>();
            FormDocuments = new HashSet<FormDocument>();
            FractionalSettlementStatements = new HashSet<FractionalSettlementStatement>();
            FractionalSsbuyerSellerAllocations = new HashSet<FractionalSsbuyerSellerAllocation>();
            GabentryRequestQueues = new HashSet<GabentryRequestQueue>();
            GabrefreshEventLogs = new HashSet<GabrefreshEventLog>();
            GenericEmails = new HashSet<GenericEmail>();
            GfeagtUwsplitInfos = new HashSet<GfeagtUwsplitInfo>();
            Gfeentries = new HashSet<Gfeentry>();
            GfeloanTerms = new HashSet<GfeloanTerm>();
            GroupResequences = new HashSet<GroupResequence>();
            HudDeliveryVersionings = new HashSet<HudDeliveryVersioning>();
            HudLineAssignmentForChargesFees = new HashSet<HudLineAssignmentForChargesFee>();
            IbabankAccounts = new HashSet<IbabankAccount>();
            InEscrowDeposits = new HashSet<InEscrowDeposit>();
            IntegrationServicesEventLogs = new HashSet<IntegrationServicesEventLog>();
            InterOfficeFees = new HashSet<InterOfficeFee>();
            InterfaceDeliveryRequests = new HashSet<InterfaceDeliveryRequest>();
            InternalAuditLogs = new HashSet<InternalAuditLog>();
            NotificationChangeEvents = new HashSet<NotificationChangeEvent>();
            OverDraftDisbursementXrefs = new HashSet<OverDraftDisbursementXref>();
            OverDraftFbpxrefs = new HashSet<OverDraftFbpxref>();
            OverDraftInEscrowDepositLinks = new HashSet<OverDraftInEscrowDepositLink>();
            OverDraftInEscrowDepositXrefs = new HashSet<OverDraftInEscrowDepositXref>();
            OverDraftMasters = new HashSet<OverDraftMaster>();
            PartnerLogs = new HashSet<PartnerLog>();
            ProgramTypeSearchInstructions = new HashSet<ProgramTypeSearchInstruction>();
            ProjectFileSalePriceLiabilityXrefs = new HashSet<ProjectFileSalePriceLiabilityXref>();
            Qcstagings = new HashSet<Qcstaging>();
            RecordedDocDetails = new HashSet<RecordedDocDetail>();
            RecordedDocEventLogs = new HashSet<RecordedDocEventLog>();
            RecordingEventLogs = new HashSet<RecordingEventLog>();
            RtmfileAddresses = new HashSet<RtmfileAddress>();
            Rtmpackages = new HashSet<Rtmpackage>();
            Sdn180daySearches = new HashSet<Sdn180daySearch>();
            SdnsearchQs = new HashSet<SdnsearchQ>();
            Sdnsearches = new HashSet<Sdnsearch>();
            Sdntrackings = new HashSet<Sdntracking>();
            SectionResequences = new HashSet<SectionResequence>();
            ServiceFees = new HashSet<ServiceFee>();
            ServiceFileAttributes = new HashSet<ServiceFileAttribute>();
            ServiceFileDeliveryInstructions = new HashSet<ServiceFileDeliveryInstruction>();
            ServiceFileDocumentXrefs = new HashSet<ServiceFileDocumentXref>();
            ServiceFileEfileXrefs = new HashSet<ServiceFileEfileXref>();
            ServiceFileEmployeeXrefs = new HashSet<ServiceFileEmployeeXref>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            ServiceFileLoanEstimateUnroundedXrefs = new HashSet<ServiceFileLoanEstimateUnroundedXref>();
            ServiceFileNotes = new HashSet<ServiceFileNote>();
            ServiceFileProductTypeXrefs = new HashSet<ServiceFileProductTypeXref>();
            ServiceFileProgInstrTypeXrefs = new HashSet<ServiceFileProgInstrTypeXref>();
            ServiceFileReverseAccounts = new HashSet<ServiceFileReverseAccount>();
            ServiceFileTagFileXrefs = new HashSet<ServiceFileTagFileXref>();
            SettlementStatementHeaderDetails = new HashSet<SettlementStatementHeaderDetail>();
            SigningEventLogs = new HashSet<SigningEventLog>();
            Signings = new HashSet<Signing>();
            SpecialInstructionServiceFileXrefs = new HashSet<SpecialInstructionServiceFileXref>();
            Subordinations = new HashSet<Subordination>();
            TempChargeFiles = new HashSet<TempChargeFile>();
            TempFileXrefs = new HashSet<TempFileXref>();
            TitleAgentsServices = new HashSet<TitleAgentsService>();
            ToleranceCures = new HashSet<ToleranceCure>();
            UndeliveredEmailDetails = new HashSet<UndeliveredEmailDetail>();
            WireReceipts = new HashSet<WireReceipt>();
            WorkQueueMessageLogs = new HashSet<WorkQueueMessageLog>();
            AddrBookEntries = new HashSet<AddrBookEntry>();
            BusinessPrograms = new HashSet<BusinessProgram>();
            Invoices = new HashSet<Invoice>();
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
        }

        public int FileId { get; set; }
        public int ClassTypeId { get; set; }
        public int OrderId { get; set; }
        public string? FileNumPrefix { get; set; }
        public string FileNum { get; set; } = null!;
        public string? FileNumSuffix { get; set; }
        public int? TransTypeCdId { get; set; }
        public int StatusCd { get; set; }
        public short BaseFileFlag { get; set; }
        public int OwnerOfficeId { get; set; }
        public int? SalesRepId { get; set; }
        public int? WorkflowId { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public string? Comments { get; set; }
        public string? FilerContactInfo { get; set; }
        public int? DirectedByRoleId { get; set; }
        public string? FilingOffAcctNum { get; set; }
        public string? ReturnCopyToInfo { get; set; }
        public int? BusinessSourceRoleId { get; set; }
        public int? OptionalDesignation { get; set; }
        public int? DocTaxFlag { get; set; }
        public int? SearchCertificateRequestFlag { get; set; }
        public short? RealEstateRecordsFlag { get; set; }
        public short? PrepareFinancingStatementFlag { get; set; }
        public short? FileFinancingStatementFlag { get; set; }
        public int CreationUserId { get; set; }
        public int? StatusChgUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? ReOpen { get; set; }
        public int? AssociatedPartyRoleId { get; set; }
        public string? ExternalFileNum { get; set; }
        public int BusSegTypeCdId { get; set; }
        public short PromulgatedFeeDisplayFlag { get; set; }
        public int? FileRateTypeId { get; set; }
        public string? ExternalId { get; set; }
        public int? ExternalApplId { get; set; }
        public short? ExternalUpdateFlag { get; set; }
        public DateTime? CreationDate { get; set; }
        public short? EmOrderFlag { get; set; }
        public short? ClearedToClose { get; set; }
        public int? BusSourceTypeId { get; set; }
        public int? HudFlag { get; set; }
        public short? CoInsuranceFlag { get; set; }
        public short? ProjectFileFlag { get; set; }
        public int? ProjectFileId { get; set; }
        public short? NextGenFlag { get; set; }
        public DateTime? ActualIdDate { get; set; }
        public string? SecondExternalFileNum { get; set; }
        public short? OverwriteSiteFileStatus { get; set; }
        public byte IsFileNotesSortingDesc { get; set; }

        public virtual TypeCdDmt BusSegTypeCd { get; set; } = null!;
        public virtual BusinessSourceType? BusSourceType { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual Application? ExternalAppl { get; set; }
        public virtual RateType? FileRateType { get; set; }
        public virtual CustomerOrder Order { get; set; } = null!;
        public virtual BusinessUnit OwnerOffice { get; set; } = null!;
        public virtual Employee? SalesRep { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual TypeCdDmt? TransTypeCd { get; set; }
        public virtual Workflow? Workflow { get; set; }
        public virtual AgentNetRemittance? AgentNetRemittance { get; set; }
        public virtual BatchDetailsBulkConversion? BatchDetailsBulkConversion { get; set; }
        public virtual CddeliveryOption? CddeliveryOption { get; set; }
        public virtual ExchangeFirstCoedate? ExchangeFirstCoedate { get; set; }
        public virtual FaccoverrideInfo? FaccoverrideInfo { get; set; }
        public virtual FileDetailsBulkConversion? FileDetailsBulkConversion { get; set; }
        public virtual FileDetailsImageDocTool? FileDetailsImageDocTool { get; set; }
        public virtual OutOfEscrowDeposit? OutOfEscrowDeposit { get; set; }
        public virtual ProjectFilePwbfeatureXref? ProjectFilePwbfeatureXref { get; set; }
        public virtual RealEstateBrokerSummary? RealEstateBrokerSummary { get; set; }
        public virtual ServiceFileLspflagXref? ServiceFileLspflagXref { get; set; }
        public virtual ServiceFileMasterFileNumXref? ServiceFileMasterFileNumXref { get; set; }
        public virtual ServiceFileSpeciallAttentionXref? ServiceFileSpeciallAttentionXref { get; set; }
        public virtual ServiceFileSplitLspflagXref? ServiceFileSplitLspflagXref { get; set; }
        public virtual ServiceFileUnderwriterXref? ServiceFileUnderwriterXref { get; set; }
        public virtual SplitLspgfe4? SplitLspgfe4 { get; set; }
        public virtual Workflow2? Workflow2 { get; set; }
        public virtual ICollection<AccountingPrivacyEventLog> AccountingPrivacyEventLogs { get; set; }
        public virtual ICollection<AgentNetPolicyNumber> AgentNetPolicyNumbers { get; set; }
        public virtual ICollection<AgentNetRemittanceCplFee> AgentNetRemittanceCplFees { get; set; }
        public virtual ICollection<ArchiveTracking> ArchiveTrackings { get; set; }
        public virtual ICollection<ChangeOwningOfficeHistory> ChangeOwningOfficeHistories { get; set; }
        public virtual ICollection<ChargeResequence> ChargeResequences { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual ICollection<ClosingDisclosureEventLog> ClosingDisclosureEventLogs { get; set; }
        public virtual ICollection<ClosingDisclosure> ClosingDisclosures { get; set; }
        public virtual ICollection<CoInsuranceLiability> CoInsuranceLiabilities { get; set; }
        public virtual ICollection<CopyDocsRequest> CopyDocsRequestSourceFiles { get; set; }
        public virtual ICollection<CopyDocsRequest> CopyDocsRequestTargetFiles { get; set; }
        public virtual ICollection<DeliveryEventLog> DeliveryEventLogs { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<DocDetailsImageDocTool> DocDetailsImageDocTools { get; set; }
        public virtual ICollection<DocumentGridFileAndScreenGridFilter> DocumentGridFileAndScreenGridFilters { get; set; }
        public virtual ICollection<DocumentPackage> DocumentPackages { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<EsigningDashboardDetail> EsigningDashboardDetails { get; set; }
        public virtual ICollection<EventLogOe> EventLogOes { get; set; }
        public virtual ICollection<ExternalFileService> ExternalFileServices { get; set; }
        public virtual ICollection<Faccrequestlog> Faccrequestlogs { get; set; }
        public virtual ICollection<Fast1099sDetail> Fast1099sDetails { get; set; }
        public virtual ICollection<Fast1099sHeader> Fast1099sHeaders { get; set; }
        public virtual ICollection<FastSearchLog> FastSearchLogs { get; set; }
        public virtual ICollection<FastSearchResult> FastSearchResults { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<FileProcess> FileProcesses { get; set; }
        public virtual ICollection<FileService> FileServices { get; set; }
        public virtual ICollection<FloridaDisclosureOverrideName> FloridaDisclosureOverrideNames { get; set; }
        public virtual ICollection<FormDocument> FormDocuments { get; set; }
        public virtual ICollection<FractionalSettlementStatement> FractionalSettlementStatements { get; set; }
        public virtual ICollection<FractionalSsbuyerSellerAllocation> FractionalSsbuyerSellerAllocations { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueues { get; set; }
        public virtual ICollection<GabrefreshEventLog> GabrefreshEventLogs { get; set; }
        public virtual ICollection<GenericEmail> GenericEmails { get; set; }
        public virtual ICollection<GfeagtUwsplitInfo> GfeagtUwsplitInfos { get; set; }
        public virtual ICollection<Gfeentry> Gfeentries { get; set; }
        public virtual ICollection<GfeloanTerm> GfeloanTerms { get; set; }
        public virtual ICollection<GroupResequence> GroupResequences { get; set; }
        public virtual ICollection<HudDeliveryVersioning> HudDeliveryVersionings { get; set; }
        public virtual ICollection<HudLineAssignmentForChargesFee> HudLineAssignmentForChargesFees { get; set; }
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDeposits { get; set; }
        public virtual ICollection<IntegrationServicesEventLog> IntegrationServicesEventLogs { get; set; }
        public virtual ICollection<InterOfficeFee> InterOfficeFees { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequests { get; set; }
        public virtual ICollection<InternalAuditLog> InternalAuditLogs { get; set; }
        public virtual ICollection<NotificationChangeEvent> NotificationChangeEvents { get; set; }
        public virtual ICollection<OverDraftDisbursementXref> OverDraftDisbursementXrefs { get; set; }
        public virtual ICollection<OverDraftFbpxref> OverDraftFbpxrefs { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositLink> OverDraftInEscrowDepositLinks { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositXref> OverDraftInEscrowDepositXrefs { get; set; }
        public virtual ICollection<OverDraftMaster> OverDraftMasters { get; set; }
        public virtual ICollection<PartnerLog> PartnerLogs { get; set; }
        public virtual ICollection<ProgramTypeSearchInstruction> ProgramTypeSearchInstructions { get; set; }
        public virtual ICollection<ProjectFileSalePriceLiabilityXref> ProjectFileSalePriceLiabilityXrefs { get; set; }
        public virtual ICollection<Qcstaging> Qcstagings { get; set; }
        public virtual ICollection<RecordedDocDetail> RecordedDocDetails { get; set; }
        public virtual ICollection<RecordedDocEventLog> RecordedDocEventLogs { get; set; }
        public virtual ICollection<RecordingEventLog> RecordingEventLogs { get; set; }
        public virtual ICollection<RtmfileAddress> RtmfileAddresses { get; set; }
        public virtual ICollection<Rtmpackage> Rtmpackages { get; set; }
        public virtual ICollection<Sdn180daySearch> Sdn180daySearches { get; set; }
        public virtual ICollection<SdnsearchQ> SdnsearchQs { get; set; }
        public virtual ICollection<Sdnsearch> Sdnsearches { get; set; }
        public virtual ICollection<Sdntracking> Sdntrackings { get; set; }
        public virtual ICollection<SectionResequence> SectionResequences { get; set; }
        public virtual ICollection<ServiceFee> ServiceFees { get; set; }
        public virtual ICollection<ServiceFileAttribute> ServiceFileAttributes { get; set; }
        public virtual ICollection<ServiceFileDeliveryInstruction> ServiceFileDeliveryInstructions { get; set; }
        public virtual ICollection<ServiceFileDocumentXref> ServiceFileDocumentXrefs { get; set; }
        public virtual ICollection<ServiceFileEfileXref> ServiceFileEfileXrefs { get; set; }
        public virtual ICollection<ServiceFileEmployeeXref> ServiceFileEmployeeXrefs { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
        public virtual ICollection<ServiceFileLoanEstimateUnroundedXref> ServiceFileLoanEstimateUnroundedXrefs { get; set; }
        public virtual ICollection<ServiceFileNote> ServiceFileNotes { get; set; }
        public virtual ICollection<ServiceFileProductTypeXref> ServiceFileProductTypeXrefs { get; set; }
        public virtual ICollection<ServiceFileProgInstrTypeXref> ServiceFileProgInstrTypeXrefs { get; set; }
        public virtual ICollection<ServiceFileReverseAccount> ServiceFileReverseAccounts { get; set; }
        public virtual ICollection<ServiceFileTagFileXref> ServiceFileTagFileXrefs { get; set; }
        public virtual ICollection<SettlementStatementHeaderDetail> SettlementStatementHeaderDetails { get; set; }
        public virtual ICollection<SigningEventLog> SigningEventLogs { get; set; }
        public virtual ICollection<Signing> Signings { get; set; }
        public virtual ICollection<SpecialInstructionServiceFileXref> SpecialInstructionServiceFileXrefs { get; set; }
        public virtual ICollection<Subordination> Subordinations { get; set; }
        public virtual ICollection<TempChargeFile> TempChargeFiles { get; set; }
        public virtual ICollection<TempFileXref> TempFileXrefs { get; set; }
        public virtual ICollection<TitleAgentsService> TitleAgentsServices { get; set; }
        public virtual ICollection<ToleranceCure> ToleranceCures { get; set; }
        public virtual ICollection<UndeliveredEmailDetail> UndeliveredEmailDetails { get; set; }
        public virtual ICollection<WireReceipt> WireReceipts { get; set; }
        public virtual ICollection<WorkQueueMessageLog> WorkQueueMessageLogs { get; set; }

        public virtual ICollection<AddrBookEntry> AddrBookEntries { get; set; }
        public virtual ICollection<BusinessProgram> BusinessPrograms { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
    }
}
