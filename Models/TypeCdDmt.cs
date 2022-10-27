using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TypeCdDmt
    {
        public TypeCdDmt()
        {
            AddrBookAddrXrefs = new HashSet<AddrBookAddrXref>();
            AddrBookElecAddrXrefs = new HashSet<AddrBookElecAddrXref>();
            AgentNetPolicyNumberProductTypeCds = new HashSet<AgentNetPolicyNumber>();
            AgentNetPolicyNumberTypeCds = new HashSet<AgentNetPolicyNumber>();
            AssociationInfos = new HashSet<AssociationInfo>();
            AuthSignatures = new HashSet<AuthSignature>();
            BuproductionOfficeXrefs = new HashSet<BuproductionOfficeXref>();
            BusOrgAlternateNames = new HashSet<BusOrgAlternateName>();
            BusOrgContactRoleRelationshipXrefs = new HashSet<BusOrgContactRoleRelationshipXref>();
            BusOrgContactRoleXrefs = new HashSet<BusOrgContactRoleXref>();
            BusOrgContactWebCustomerXrefs = new HashSet<BusOrgContactWebCustomerXref>();
            BusOrgDocumentCopiesXrefs = new HashSet<BusOrgDocumentCopiesXref>();
            BusOrgLicenseDetailsXrefs = new HashSet<BusOrgLicenseDetailsXref>();
            BusOrgMortgageProductLoanTypeCds = new HashSet<BusOrgMortgageProduct>();
            BusOrgMortgageProductMortgageProductTypeCds = new HashSet<BusOrgMortgageProduct>();
            BusOrgOrgTypeCds = new HashSet<BusOrg>();
            BusOrgRoleRelationshipXrefs = new HashSet<BusOrgRoleRelationshipXref>();
            BusOrgTitleAgentTypeCds = new HashSet<BusOrg>();
            BusOrgWebCustomerXrefs = new HashSet<BusOrgWebCustomerXref>();
            BusUnitAutoNumbers = new HashSet<BusUnitAutoNumber>();
            BusinessProgramBusOrgChangeHistories = new HashSet<BusinessProgramBusOrgChangeHistory>();
            BusinessProgramBusOrgContactChangeHistories = new HashSet<BusinessProgramBusOrgContactChangeHistory>();
            BusinessProgramBusUnitChangeHistories = new HashSet<BusinessProgramBusUnitChangeHistory>();
            BusinessUnitBusUnitTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitExchangeOfficeTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitPolicyIssuedByTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitProdSystemTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitReportingOffTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitSolrSearchTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitTitleAgentTypeCds = new HashSet<BusinessUnit>();
            BusinessUnitXrefs = new HashSet<BusinessUnitXref>();
            CdadjustableInterestRates = new HashSet<CdadjustableInterestRate>();
            CdadjustablePayments = new HashSet<CdadjustablePayment>();
            CdcalculatingCashToCloses = new HashSet<CdcalculatingCashToClose>();
            CdsplitOwnerPolicyAmts = new HashSet<CdsplitOwnerPolicyAmt>();
            ChangeOwningOfficeHistories = new HashSet<ChangeOwningOfficeHistory>();
            ChargeAdditionalInfoXrefs = new HashSet<ChargeAdditionalInfoXref>();
            ChargeChargeCategoryTypeCds = new HashSet<Charge>();
            ChargeChargeProcessTypeCds = new HashSet<Charge>();
            ChargeExchDisbTypeCds = new HashSet<Charge>();
            ChargeInterestTypeCds = new HashSet<Charge>();
            ChargePaymentTermTypeCds = new HashSet<Charge>();
            ChargeSellerPaymentMethodTypeCds = new HashSet<Charge>();
            ChargeSourceTypeCds = new HashSet<Charge>();
            ChargeStatusTypeCds = new HashSet<Charge>();
            ChargeTransactionTypeCds = new HashSet<Charge>();
            ClassTypeTypeCdXrefs = new HashSet<ClassTypeTypeCdXref>();
            ClosingDisclosureLenderInfos = new HashSet<ClosingDisclosureLenderInfo>();
            CopyDocsRequests = new HashSet<CopyDocsRequest>();
            CopyToDocPrefs = new HashSet<CopyToDocPref>();
            CorpCpuproductionOffices = new HashSet<CorpCpuproductionOffice>();
            CorpEbusInterfaceFormatXrefs = new HashSet<CorpEbusInterfaceFormatXref>();
            CustomaryServiceFees = new HashSet<CustomaryServiceFee>();
            CustomerOptionDocumentTemplateCustomerOptionDocTypeCds = new HashSet<CustomerOptionDocumentTemplate>();
            CustomerOptionDocumentTemplateStatusCds = new HashSet<CustomerOptionDocumentTemplate>();
            DataElementDmtAlignmentTypeCds = new HashSet<DataElementDmt>();
            DataElementDmtDataElementTypeCds = new HashSet<DataElementDmt>();
            DataElementDmtDomainTypeCds = new HashSet<DataElementDmt>();
            DataElementDmtElementSeparatorTypeCds = new HashSet<DataElementDmt>();
            DataElementDmtFormatTypeCds = new HashSet<DataElementDmt>();
            DataElementDmtPictureTypeCds = new HashSet<DataElementDmt>();
            DataElementDmtPrintCaseTypeCds = new HashSet<DataElementDmt>();
            DepositAdjustmentCommentCauseLossTypeCds = new HashSet<DepositAdjustmentComment>();
            DepositAdjustmentCommentProcessTypeCds = new HashSet<DepositAdjustmentComment>();
            DepositAdjustmentCommentTypeLossTypeCds = new HashSet<DepositAdjustmentComment>();
            DepositLists = new HashSet<DepositList>();
            DepositedReceipts = new HashSet<DepositedReceipt>();
            DisbursementAdjustmentReasonTypeCds = new HashSet<Disbursement>();
            DisbursementDisplayOrderProcessTypeCds = new HashSet<DisbursementDisplayOrder>();
            DisbursementDisplayOrderRoleTypeCds = new HashSet<DisbursementDisplayOrder>();
            DisbursementFileFeeDisbursementCauseTypeCds = new HashSet<Disbursement>();
            DisbursementSourceTypeCds = new HashSet<Disbursement>();
            DisbursementStatusTypeCds = new HashSet<Disbursement>();
            DisbursementTrackInfos = new HashSet<DisbursementTrackInfo>();
            DisbursementTransactionTypeCds = new HashSet<Disbursement>();
            DocTypeDmts = new HashSet<DocTypeDmt>();
            DocphraseelementAlignmentTypeCds = new HashSet<Docphraseelement>();
            DocphraseelementElementSeparatorTypeCds = new HashSet<Docphraseelement>();
            DocphraseelementFormatTypeCds = new HashSet<Docphraseelement>();
            DocphraseelementPictureTypeCds = new HashSet<Docphraseelement>();
            DocphraseelementPrintCaseTypeCds = new HashSet<Docphraseelement>();
            DocumentPackageAssociatedDocumentXrefs = new HashSet<DocumentPackageAssociatedDocumentXref>();
            DocumentRules = new HashSet<DocumentRule>();
            EarnestDeposits = new HashSet<EarnestDeposit>();
            EbusinessRequestEbusInterfaceFormatCds = new HashSet<EbusinessRequest>();
            EbusinessRequestEbusinessTypeCds = new HashSet<EbusinessRequest>();
            EmployeeCountyInfoXrefs = new HashSet<EmployeeCountyInfoXref>();
            EmployeeFunctionXrefs = new HashSet<EmployeeFunctionXref>();
            EmployeeSecurityChangeHistories = new HashSet<EmployeeSecurityChangeHistory>();
            EndorsementNames = new HashSet<Endorsement>();
            EndorsementTypeCds = new HashSet<Endorsement>();
            EscrowChargeTemplateCalcBasePeriodTypeCds = new HashSet<EscrowChargeTemplate>();
            EscrowChargeTemplateChargeCategoryTypeCds = new HashSet<EscrowChargeTemplate>();
            EscrowChargeTemplateChargeProcessTypeCds = new HashSet<EscrowChargeTemplate>();
            EscrowChargeTemplateDefaultPaymentCategoryTypeCds = new HashSet<EscrowChargeTemplate>();
            EscrowChargeTemplateDefaultPmtMethodTypeCds = new HashSet<EscrowChargeTemplate>();
            EsigningCredentials = new HashSet<EsigningCredential>();
            EsigningDashboardDetailEsigningPlatformNavigations = new HashSet<EsigningDashboardDetail>();
            EsigningDashboardDetailEsigningStatusNavigations = new HashSet<EsigningDashboardDetail>();
            ExternalFileServices = new HashSet<ExternalFileService>();
            FaccadditionalParams = new HashSet<FaccadditionalParam>();
            FaccclosingCosts = new HashSet<FaccclosingCost>();
            FaccendorsementOverRideTypecds = new HashSet<Faccendorsement>();
            FaccendorsementTitlePolicyTypecds = new HashSet<Faccendorsement>();
            FaccoverrideInfos = new HashSet<FaccoverrideInfo>();
            FaccpolicyProductxrefs = new HashSet<FaccpolicyProductxref>();
            FaccrecordingFees = new HashSet<FaccrecordingFee>();
            FacctitlePolicies = new HashSet<FacctitlePolicy>();
            Fast1099sHeaders = new HashSet<Fast1099sHeader>();
            FbpserviceTypeXrefs = new HashSet<FbpserviceTypeXref>();
            FctloanInfoMortgageProductTypeCds = new HashSet<FctloanInfo>();
            FctloanInfoProductOptionTypeCds = new HashSet<FctloanInfo>();
            FeeChargeToTypeCds = new HashSet<Fee>();
            FeeFeeToBucketNavigations = new HashSet<Fee>();
            FeeFeeTypeCds = new HashSet<Fee>();
            FeeGeographicTypeCds = new HashSet<Fee>();
            FftchangeHistories = new HashSet<FftchangeHistory>();
            FfttypeCdDmtXrefs = new HashSet<FfttypeCdDmtXref>();
            FieldTemplateDisplayTypeCds = new HashSet<FieldTemplate>();
            FieldTemplateFlowRuleTypeCds = new HashSet<FieldTemplate>();
            FileBusinessPartyDisableNotificationCds = new HashSet<FileBusinessParty>();
            FileBusinessPartyEntitySubTypeCds = new HashSet<FileBusinessParty>();
            FileBusinessPartyRoleTypeCds = new HashSet<FileBusinessParty>();
            FileBusinessPartyTitleAgentTypeCds = new HashSet<FileBusinessParty>();
            FileEntries = new HashSet<FileEntry>();
            FileProcesses = new HashSet<FileProcess>();
            FileServices = new HashSet<FileService>();
            FormDocumentOrientationTypeCds = new HashSet<FormDocument>();
            FormDocumentPaperSizeTypeCds = new HashSet<FormDocument>();
            FormTemplateDocTypeCds = new HashSet<FormTemplate>();
            FormTemplateOrientationTypeCds = new HashSet<FormTemplate>();
            FormTemplatePaperSizeTypeCds = new HashSet<FormTemplate>();
            FormTemplatePrinterTypeCds = new HashSet<FormTemplate>();
            GabentryRequestQueueRequestTypeCds = new HashSet<GabentryRequestQueue>();
            GabentryRequestQueueRoleTypeCds = new HashSet<GabentryRequestQueue>();
            GuinodeCustomizations = new HashSet<GuinodeCustomization>();
            HomeWarrantyInfos = new HashSet<HomeWarrantyInfo>();
            IbabankAccounts = new HashSet<IbabankAccount>();
            IbabankBranches = new HashSet<IbabankBranch>();
            IbatransactionStatusCdNavigations = new HashSet<Ibatransaction>();
            IbatransactionStatusLogs = new HashSet<IbatransactionStatusLog>();
            IbatransactionTransactionTypeCds = new HashSet<Ibatransaction>();
            InEscrowDepositAdjustmentReasonTypeCds = new HashSet<InEscrowDeposit>();
            InEscrowDepositCreditToTypeCds = new HashSet<InEscrowDeposit>();
            InEscrowDepositDepositorTypeCds = new HashSet<InEscrowDeposit>();
            InEscrowDepositRepresentingTypeCds = new HashSet<InEscrowDeposit>();
            InEscrowDepositSourceTypeCds = new HashSet<InEscrowDeposit>();
            InEscrowDepositStatusTypeCds = new HashSet<InEscrowDeposit>();
            InEscrowDepositTransactionTypeCds = new HashSet<InEscrowDeposit>();
            IncomingWireDeposits = new HashSet<IncomingWireDeposit>();
            IncomingWireDetails = new HashSet<IncomingWireDetail>();
            IncomingWires = new HashSet<IncomingWire>();
            InspReprInfos = new HashSet<InspReprInfo>();
            InsuranceInfos = new HashSet<InsuranceInfo>();
            InternalAuditLogs = new HashSet<InternalAuditLog>();
            InverseSuperTypeCd = new HashSet<TypeCdDmt>();
            InvoiceBillToEntityRoleTypeCds = new HashSet<Invoice>();
            InvoiceInvoiceStatusCds = new HashSet<Invoice>();
            LeaseInfos = new HashSet<LeaseInfo>();
            LicenseInformationLogs = new HashSet<LicenseInformationLog>();
            LicenseTypeGeoRegionXrefs = new HashSet<LicenseTypeGeoRegionXref>();
            LoanInfoLoanTermTypeCds = new HashSet<LoanInfo>();
            LoanInfoLoanTypeCds = new HashSet<LoanInfo>();
            LoanInfoPayablePeriodTypeCds = new HashSet<LoanInfo>();
            LoanInfoPmtTypeCds = new HashSet<LoanInfo>();
            MdmtypeCodeMappings = new HashSet<MdmtypeCodeMapping>();
            NotificationChangeEvents = new HashSet<NotificationChangeEvent>();
            NotificationTemplateFbproleXrefs = new HashSet<NotificationTemplateFbproleXref>();
            NotificationTemplateSenderInfoXrefs = new HashSet<NotificationTemplateSenderInfoXref>();
            OfficePrinterPrefrences = new HashSet<OfficePrinterPrefrence>();
            OfficeProductChangeHistories = new HashSet<OfficeProductChangeHistory>();
            OutOfEscrowDepositSourceTypeCds = new HashSet<OutOfEscrowDeposit>();
            OutOfEscrowDepositStatusTypeCds = new HashSet<OutOfEscrowDeposit>();
            OutOfEscrowDepositTransactionTypeCds = new HashSet<OutOfEscrowDeposit>();
            OverDraftInEscrowDepositLinks = new HashSet<OverDraftInEscrowDepositLink>();
            OverDraftMasterCauseLossTypeCds = new HashSet<OverDraftMaster>();
            OverDraftMasterProcessTypeCds = new HashSet<OverDraftMaster>();
            OverDraftMasterTypeLossTypeCds = new HashSet<OverDraftMaster>();
            OverdraftDisbursementCauseLossTypeCds = new HashSet<OverdraftDisbursement>();
            OverdraftDisbursementProcessTypeCds = new HashSet<OverdraftDisbursement>();
            OverdraftDisbursementTypeLossTypeCds = new HashSet<OverdraftDisbursement>();
            PaidDisbursements = new HashSet<PaidDisbursement>();
            PaidStatusLogs = new HashSet<PaidStatusLog>();
            PartnerLogs = new HashSet<PartnerLog>();
            PaymentCardTypeCds = new HashSet<Payment>();
            PaymentPaymentMethodTypeCds = new HashSet<Payment>();
            PaymentTransactionTypeCds = new HashSet<Payment>();
            PersonBpchangeHistories = new HashSet<PersonBpchangeHistory>();
            PersonRoleRelationshipXrefs = new HashSet<PersonRoleRelationshipXref>();
            PersonWebCustomerXrefs = new HashSet<PersonWebCustomerXref>();
            PhraseElementAlignmentTypeCds = new HashSet<PhraseElement>();
            PhraseElementElementSeparatorTypeCds = new HashSet<PhraseElement>();
            PhraseElementFormatTypeCds = new HashSet<PhraseElement>();
            PhraseElementPictureTypeCds = new HashSet<PhraseElement>();
            PhraseElementPrintCaseTypeCds = new HashSet<PhraseElement>();
            PhraseGrps = new HashSet<PhraseGrp>();
            PreferredBusOrgContactXrefs = new HashSet<PreferredBusOrgContactXref>();
            PreferredEmployeeContactXrefs = new HashSet<PreferredEmployeeContactXref>();
            PreferredPersonXrefs = new HashSet<PreferredPersonXref>();
            PrincipalAddInfoLangPrefTypeCds = new HashSet<PrincipalAddInfo>();
            PrincipalAddInfoSpouseLangPrefTypeCds = new HashSet<PrincipalAddInfo>();
            PrincipalBusEntities = new HashSet<PrincipalBusEntity>();
            PrincipalOrgTypeCds = new HashSet<Principal>();
            PrincipalSignatures = new HashSet<PrincipalSignature>();
            PrincipalSms1099classificationCds = new HashSet<Principal>();
            PrincipalSpouse1099ClassificationCds = new HashSet<Principal>();
            PrincipalTypeCds = new HashSet<Principal>();
            PrincipalVestingMaritalStatusTypeCds = new HashSet<Principal>();
            PrincipalVestingTypeCds = new HashSet<Principal>();
            ProcessTemplateWebCustomerXrefs = new HashSet<ProcessTemplateWebCustomerXref>();
            ProcessTypeRoleTypeMapProcessTypeCds = new HashSet<ProcessTypeRoleTypeMap>();
            ProcessTypeRoleTypeMapRoleTypeCds = new HashSet<ProcessTypeRoleTypeMap>();
            ProductTypeBusUnitXrefs = new HashSet<ProductTypeBusUnitXref>();
            ProfileChangeHistories = new HashSet<ProfileChangeHistory>();
            ProgramTypeGeographicXrefs = new HashSet<ProgramTypeGeographicXref>();
            ProgramTypeProductTypeXrefs = new HashSet<ProgramTypeProductTypeXref>();
            ProgramTypeSearchInstructions = new HashSet<ProgramTypeSearchInstruction>();
            ProgramTypeTransTypeXrefs = new HashSet<ProgramTypeTransTypeXref>();
            ProjectFileSalePriceLiabilityXrefs = new HashSet<ProjectFileSalePriceLiabilityXref>();
            QcstagingMismotypeCds = new HashSet<Qcstaging>();
            QcstagingQcstatusCds = new HashSet<Qcstaging>();
            QcstagingSectionXrefs = new HashSet<QcstagingSectionXref>();
            RealPropertyEstateTypeCds = new HashSet<RealProperty>();
            RealPropertyPropertyTypeCds = new HashSet<RealProperty>();
            RecordedDocDetails = new HashSet<RecordedDocDetail>();
            RecordingInfos = new HashSet<RecordingInfo>();
            RegionIdforApplications = new HashSet<RegionIdforApplication>();
            RoleChangeHistories = new HashSet<RoleChangeHistory>();
            RtmaddressCourierTypeNavigations = new HashSet<Rtmaddress>();
            RtmaddressEmployeeRoleTypeCds = new HashSet<Rtmaddress>();
            RtmaddressPackageTypeNavigations = new HashSet<Rtmaddress>();
            RtmaddressPhysicalAddrTypeCds = new HashSet<Rtmaddress>();
            Rtmdocuments = new HashSet<Rtmdocument>();
            SalesRepHistories = new HashSet<SalesRepHistory>();
            SearchTypeTypeCdXrefs = new HashSet<SearchTypeTypeCdXref>();
            SecOffcGrpChangeHistories = new HashSet<SecOffcGrpChangeHistory>();
            ServiceFileAttributes = new HashSet<ServiceFileAttribute>();
            ServiceFileBusSegTypeCds = new HashSet<ServiceFile>();
            ServiceFileEmployeeXrefs = new HashSet<ServiceFileEmployeeXref>();
            ServiceFileFeeDefaultPaymentMethodTypeCds = new HashSet<ServiceFileFee>();
            ServiceFileFeeFeeToBucketNavigations = new HashSet<ServiceFileFee>();
            ServiceFileFeeFeeTypeCds = new HashSet<ServiceFileFee>();
            ServiceFileFeeFileFeeCategoryTypeCds = new HashSet<ServiceFileFee>();
            ServiceFileFeeFileTransactionTypeCds = new HashSet<ServiceFileFee>();
            ServiceFileFeeGeographicTypeCds = new HashSet<ServiceFileFee>();
            ServiceFileFeePaymentDetailChargePaidByTypeCds = new HashSet<ServiceFileFeePaymentDetail>();
            ServiceFileFeePaymentDetailPaymentMethodTypeCds = new HashSet<ServiceFileFeePaymentDetail>();
            ServiceFileFeePaymentMethodTypeCds = new HashSet<ServiceFileFee>();
            ServiceFileNotes = new HashSet<ServiceFileNote>();
            ServiceFileProductTypeXrefs = new HashSet<ServiceFileProductTypeXref>();
            ServiceFileTagFileXrefs = new HashSet<ServiceFileTagFileXref>();
            ServiceFileTransTypeCds = new HashSet<ServiceFile>();
            SigningAddrXrefs = new HashSet<SigningAddrXref>();
            SigningParties = new HashSet<SigningParty>();
            SigningPartyElecAddrXrefs = new HashSet<SigningPartyElecAddrXref>();
            SigningProposedTimeRangeTypeCds = new HashSet<Signing>();
            SigningProposedTimeZoneTypeCds = new HashSet<Signing>();
            SigningSigningLocTypeCds = new HashSet<Signing>();
            SigningSigningMethodTypeCds = new HashSet<Signing>();
            SigningSigningQualities = new HashSet<Signing>();
            SigningStatusCdNavigations = new HashSet<Signing>();
            SplitFees = new HashSet<SplitFee>();
            StateBusSegMappingBusinessSegments = new HashSet<StateBusSegMapping>();
            StateBusSegMappingTransactionTypes = new HashSet<StateBusSegMapping>();
            SubordinationLenderDetails = new HashSet<SubordinationLenderDetail>();
            TaskTemplateCustomerXrefs = new HashSet<TaskTemplateCustomerXref>();
            TaskTemplates = new HashSet<TaskTemplate>();
            TaxExemptions = new HashSet<TaxExemption>();
            TaxInstallments = new HashSet<TaxInstallment>();
            TaxRateInfoTaxBaseMethodTypeCds = new HashSet<TaxRateInfo>();
            TaxRateInfoTaxRateTypeCds = new HashSet<TaxRateInfo>();
            TemplateBusinessPartyEntitySubTypeCds = new HashSet<TemplateBusinessParty>();
            TemplateBusinessPartyRoleTypeCds = new HashSet<TemplateBusinessParty>();
            TemplatePageLayouts = new HashSet<TemplatePageLayout>();
            TemplateProductTypeXrefDocPreps = new HashSet<TemplateProductTypeXrefDocPrep>();
            TemplateProductTypeXrefs = new HashSet<TemplateProductTypeXref>();
            TitleEscrowInfoLiabilityXrefs = new HashSet<TitleEscrowInfoLiabilityXref>();
            TitleEscrowInfoSalesPriceXrefs = new HashSet<TitleEscrowInfoSalesPriceXref>();
            UserLoginHistories = new HashSet<UserLoginHistory>();
            VendorInfos = new HashSet<VendorInfo>();
            WireDisbursementDetails = new HashSet<WireDisbursementDetail>();
            WireHistories = new HashSet<WireHistory>();
            WorkFlowTemplateAdditionalRoleTypeXrefs = new HashSet<WorkFlowTemplateAdditionalRoleTypeXref>();
            WorkFlowTemplateApnxrefs = new HashSet<WorkFlowTemplateApnxref>();
            WorkFlowTemplateChangeHistories = new HashSet<WorkFlowTemplateChangeHistory>();
            WorkFlowTemplateOriginatorXrefs = new HashSet<WorkFlowTemplateOriginatorXref>();
            WorkFlowTemplateProductTypeCds = new HashSet<WorkFlowTemplate>();
            WorkFlowTemplateProductTypeXrefs = new HashSet<WorkFlowTemplateProductTypeXref>();
            WorkFlowTemplateRoleTypeCds = new HashSet<WorkFlowTemplate>();
            WorkQueueMessages = new HashSet<WorkQueueMessage>();
            WorkQueueTypes = new HashSet<WorkQueueType>();
            Workflows = new HashSet<Workflow>();
        }

        public int TypeCdId { get; set; }
        public int ClassTypeId { get; set; }
        public int? SuperTypeCdId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public string? Descr { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? SuperTypeCd { get; set; }
        public virtual FaccbusinessSegmentXref? FaccbusinessSegmentXref { get; set; }
        public virtual FacctransactionTypeXref? FacctransactionTypeXref { get; set; }
        public virtual ThresholdAmount? ThresholdAmount { get; set; }
        public virtual ICollection<AddrBookAddrXref> AddrBookAddrXrefs { get; set; }
        public virtual ICollection<AddrBookElecAddrXref> AddrBookElecAddrXrefs { get; set; }
        public virtual ICollection<AgentNetPolicyNumber> AgentNetPolicyNumberProductTypeCds { get; set; }
        public virtual ICollection<AgentNetPolicyNumber> AgentNetPolicyNumberTypeCds { get; set; }
        public virtual ICollection<AssociationInfo> AssociationInfos { get; set; }
        public virtual ICollection<AuthSignature> AuthSignatures { get; set; }
        public virtual ICollection<BuproductionOfficeXref> BuproductionOfficeXrefs { get; set; }
        public virtual ICollection<BusOrgAlternateName> BusOrgAlternateNames { get; set; }
        public virtual ICollection<BusOrgContactRoleRelationshipXref> BusOrgContactRoleRelationshipXrefs { get; set; }
        public virtual ICollection<BusOrgContactRoleXref> BusOrgContactRoleXrefs { get; set; }
        public virtual ICollection<BusOrgContactWebCustomerXref> BusOrgContactWebCustomerXrefs { get; set; }
        public virtual ICollection<BusOrgDocumentCopiesXref> BusOrgDocumentCopiesXrefs { get; set; }
        public virtual ICollection<BusOrgLicenseDetailsXref> BusOrgLicenseDetailsXrefs { get; set; }
        public virtual ICollection<BusOrgMortgageProduct> BusOrgMortgageProductLoanTypeCds { get; set; }
        public virtual ICollection<BusOrgMortgageProduct> BusOrgMortgageProductMortgageProductTypeCds { get; set; }
        public virtual ICollection<BusOrg> BusOrgOrgTypeCds { get; set; }
        public virtual ICollection<BusOrgRoleRelationshipXref> BusOrgRoleRelationshipXrefs { get; set; }
        public virtual ICollection<BusOrg> BusOrgTitleAgentTypeCds { get; set; }
        public virtual ICollection<BusOrgWebCustomerXref> BusOrgWebCustomerXrefs { get; set; }
        public virtual ICollection<BusUnitAutoNumber> BusUnitAutoNumbers { get; set; }
        public virtual ICollection<BusinessProgramBusOrgChangeHistory> BusinessProgramBusOrgChangeHistories { get; set; }
        public virtual ICollection<BusinessProgramBusOrgContactChangeHistory> BusinessProgramBusOrgContactChangeHistories { get; set; }
        public virtual ICollection<BusinessProgramBusUnitChangeHistory> BusinessProgramBusUnitChangeHistories { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitBusUnitTypeCds { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitExchangeOfficeTypeCds { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitPolicyIssuedByTypeCds { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitProdSystemTypeCds { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitReportingOffTypeCds { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitSolrSearchTypeCds { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitTitleAgentTypeCds { get; set; }
        public virtual ICollection<BusinessUnitXref> BusinessUnitXrefs { get; set; }
        public virtual ICollection<CdadjustableInterestRate> CdadjustableInterestRates { get; set; }
        public virtual ICollection<CdadjustablePayment> CdadjustablePayments { get; set; }
        public virtual ICollection<CdcalculatingCashToClose> CdcalculatingCashToCloses { get; set; }
        public virtual ICollection<CdsplitOwnerPolicyAmt> CdsplitOwnerPolicyAmts { get; set; }
        public virtual ICollection<ChangeOwningOfficeHistory> ChangeOwningOfficeHistories { get; set; }
        public virtual ICollection<ChargeAdditionalInfoXref> ChargeAdditionalInfoXrefs { get; set; }
        public virtual ICollection<Charge> ChargeChargeCategoryTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeChargeProcessTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeExchDisbTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeInterestTypeCds { get; set; }
        public virtual ICollection<Charge> ChargePaymentTermTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeSellerPaymentMethodTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeSourceTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeStatusTypeCds { get; set; }
        public virtual ICollection<Charge> ChargeTransactionTypeCds { get; set; }
        public virtual ICollection<ClassTypeTypeCdXref> ClassTypeTypeCdXrefs { get; set; }
        public virtual ICollection<ClosingDisclosureLenderInfo> ClosingDisclosureLenderInfos { get; set; }
        public virtual ICollection<CopyDocsRequest> CopyDocsRequests { get; set; }
        public virtual ICollection<CopyToDocPref> CopyToDocPrefs { get; set; }
        public virtual ICollection<CorpCpuproductionOffice> CorpCpuproductionOffices { get; set; }
        public virtual ICollection<CorpEbusInterfaceFormatXref> CorpEbusInterfaceFormatXrefs { get; set; }
        public virtual ICollection<CustomaryServiceFee> CustomaryServiceFees { get; set; }
        public virtual ICollection<CustomerOptionDocumentTemplate> CustomerOptionDocumentTemplateCustomerOptionDocTypeCds { get; set; }
        public virtual ICollection<CustomerOptionDocumentTemplate> CustomerOptionDocumentTemplateStatusCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtAlignmentTypeCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtDataElementTypeCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtDomainTypeCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtElementSeparatorTypeCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtFormatTypeCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtPictureTypeCds { get; set; }
        public virtual ICollection<DataElementDmt> DataElementDmtPrintCaseTypeCds { get; set; }
        public virtual ICollection<DepositAdjustmentComment> DepositAdjustmentCommentCauseLossTypeCds { get; set; }
        public virtual ICollection<DepositAdjustmentComment> DepositAdjustmentCommentProcessTypeCds { get; set; }
        public virtual ICollection<DepositAdjustmentComment> DepositAdjustmentCommentTypeLossTypeCds { get; set; }
        public virtual ICollection<DepositList> DepositLists { get; set; }
        public virtual ICollection<DepositedReceipt> DepositedReceipts { get; set; }
        public virtual ICollection<Disbursement> DisbursementAdjustmentReasonTypeCds { get; set; }
        public virtual ICollection<DisbursementDisplayOrder> DisbursementDisplayOrderProcessTypeCds { get; set; }
        public virtual ICollection<DisbursementDisplayOrder> DisbursementDisplayOrderRoleTypeCds { get; set; }
        public virtual ICollection<Disbursement> DisbursementFileFeeDisbursementCauseTypeCds { get; set; }
        public virtual ICollection<Disbursement> DisbursementSourceTypeCds { get; set; }
        public virtual ICollection<Disbursement> DisbursementStatusTypeCds { get; set; }
        public virtual ICollection<DisbursementTrackInfo> DisbursementTrackInfos { get; set; }
        public virtual ICollection<Disbursement> DisbursementTransactionTypeCds { get; set; }
        public virtual ICollection<DocTypeDmt> DocTypeDmts { get; set; }
        public virtual ICollection<Docphraseelement> DocphraseelementAlignmentTypeCds { get; set; }
        public virtual ICollection<Docphraseelement> DocphraseelementElementSeparatorTypeCds { get; set; }
        public virtual ICollection<Docphraseelement> DocphraseelementFormatTypeCds { get; set; }
        public virtual ICollection<Docphraseelement> DocphraseelementPictureTypeCds { get; set; }
        public virtual ICollection<Docphraseelement> DocphraseelementPrintCaseTypeCds { get; set; }
        public virtual ICollection<DocumentPackageAssociatedDocumentXref> DocumentPackageAssociatedDocumentXrefs { get; set; }
        public virtual ICollection<DocumentRule> DocumentRules { get; set; }
        public virtual ICollection<EarnestDeposit> EarnestDeposits { get; set; }
        public virtual ICollection<EbusinessRequest> EbusinessRequestEbusInterfaceFormatCds { get; set; }
        public virtual ICollection<EbusinessRequest> EbusinessRequestEbusinessTypeCds { get; set; }
        public virtual ICollection<EmployeeCountyInfoXref> EmployeeCountyInfoXrefs { get; set; }
        public virtual ICollection<EmployeeFunctionXref> EmployeeFunctionXrefs { get; set; }
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistories { get; set; }
        public virtual ICollection<Endorsement> EndorsementNames { get; set; }
        public virtual ICollection<Endorsement> EndorsementTypeCds { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplateCalcBasePeriodTypeCds { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplateChargeCategoryTypeCds { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplateChargeProcessTypeCds { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplateDefaultPaymentCategoryTypeCds { get; set; }
        public virtual ICollection<EscrowChargeTemplate> EscrowChargeTemplateDefaultPmtMethodTypeCds { get; set; }
        public virtual ICollection<EsigningCredential> EsigningCredentials { get; set; }
        public virtual ICollection<EsigningDashboardDetail> EsigningDashboardDetailEsigningPlatformNavigations { get; set; }
        public virtual ICollection<EsigningDashboardDetail> EsigningDashboardDetailEsigningStatusNavigations { get; set; }
        public virtual ICollection<ExternalFileService> ExternalFileServices { get; set; }
        public virtual ICollection<FaccadditionalParam> FaccadditionalParams { get; set; }
        public virtual ICollection<FaccclosingCost> FaccclosingCosts { get; set; }
        public virtual ICollection<Faccendorsement> FaccendorsementOverRideTypecds { get; set; }
        public virtual ICollection<Faccendorsement> FaccendorsementTitlePolicyTypecds { get; set; }
        public virtual ICollection<FaccoverrideInfo> FaccoverrideInfos { get; set; }
        public virtual ICollection<FaccpolicyProductxref> FaccpolicyProductxrefs { get; set; }
        public virtual ICollection<FaccrecordingFee> FaccrecordingFees { get; set; }
        public virtual ICollection<FacctitlePolicy> FacctitlePolicies { get; set; }
        public virtual ICollection<Fast1099sHeader> Fast1099sHeaders { get; set; }
        public virtual ICollection<FbpserviceTypeXref> FbpserviceTypeXrefs { get; set; }
        public virtual ICollection<FctloanInfo> FctloanInfoMortgageProductTypeCds { get; set; }
        public virtual ICollection<FctloanInfo> FctloanInfoProductOptionTypeCds { get; set; }
        public virtual ICollection<Fee> FeeChargeToTypeCds { get; set; }
        public virtual ICollection<Fee> FeeFeeToBucketNavigations { get; set; }
        public virtual ICollection<Fee> FeeFeeTypeCds { get; set; }
        public virtual ICollection<Fee> FeeGeographicTypeCds { get; set; }
        public virtual ICollection<FftchangeHistory> FftchangeHistories { get; set; }
        public virtual ICollection<FfttypeCdDmtXref> FfttypeCdDmtXrefs { get; set; }
        public virtual ICollection<FieldTemplate> FieldTemplateDisplayTypeCds { get; set; }
        public virtual ICollection<FieldTemplate> FieldTemplateFlowRuleTypeCds { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartyDisableNotificationCds { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartyEntitySubTypeCds { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartyRoleTypeCds { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessPartyTitleAgentTypeCds { get; set; }
        public virtual ICollection<FileEntry> FileEntries { get; set; }
        public virtual ICollection<FileProcess> FileProcesses { get; set; }
        public virtual ICollection<FileService> FileServices { get; set; }
        public virtual ICollection<FormDocument> FormDocumentOrientationTypeCds { get; set; }
        public virtual ICollection<FormDocument> FormDocumentPaperSizeTypeCds { get; set; }
        public virtual ICollection<FormTemplate> FormTemplateDocTypeCds { get; set; }
        public virtual ICollection<FormTemplate> FormTemplateOrientationTypeCds { get; set; }
        public virtual ICollection<FormTemplate> FormTemplatePaperSizeTypeCds { get; set; }
        public virtual ICollection<FormTemplate> FormTemplatePrinterTypeCds { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueRequestTypeCds { get; set; }
        public virtual ICollection<GabentryRequestQueue> GabentryRequestQueueRoleTypeCds { get; set; }
        public virtual ICollection<GuinodeCustomization> GuinodeCustomizations { get; set; }
        public virtual ICollection<HomeWarrantyInfo> HomeWarrantyInfos { get; set; }
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<IbabankBranch> IbabankBranches { get; set; }
        public virtual ICollection<Ibatransaction> IbatransactionStatusCdNavigations { get; set; }
        public virtual ICollection<IbatransactionStatusLog> IbatransactionStatusLogs { get; set; }
        public virtual ICollection<Ibatransaction> IbatransactionTransactionTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositAdjustmentReasonTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositCreditToTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositDepositorTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositRepresentingTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositSourceTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositStatusTypeCds { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDepositTransactionTypeCds { get; set; }
        public virtual ICollection<IncomingWireDeposit> IncomingWireDeposits { get; set; }
        public virtual ICollection<IncomingWireDetail> IncomingWireDetails { get; set; }
        public virtual ICollection<IncomingWire> IncomingWires { get; set; }
        public virtual ICollection<InspReprInfo> InspReprInfos { get; set; }
        public virtual ICollection<InsuranceInfo> InsuranceInfos { get; set; }
        public virtual ICollection<InternalAuditLog> InternalAuditLogs { get; set; }
        public virtual ICollection<TypeCdDmt> InverseSuperTypeCd { get; set; }
        public virtual ICollection<Invoice> InvoiceBillToEntityRoleTypeCds { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceStatusCds { get; set; }
        public virtual ICollection<LeaseInfo> LeaseInfos { get; set; }
        public virtual ICollection<LicenseInformationLog> LicenseInformationLogs { get; set; }
        public virtual ICollection<LicenseTypeGeoRegionXref> LicenseTypeGeoRegionXrefs { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoLoanTermTypeCds { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoLoanTypeCds { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoPayablePeriodTypeCds { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoPmtTypeCds { get; set; }
        public virtual ICollection<MdmtypeCodeMapping> MdmtypeCodeMappings { get; set; }
        public virtual ICollection<NotificationChangeEvent> NotificationChangeEvents { get; set; }
        public virtual ICollection<NotificationTemplateFbproleXref> NotificationTemplateFbproleXrefs { get; set; }
        public virtual ICollection<NotificationTemplateSenderInfoXref> NotificationTemplateSenderInfoXrefs { get; set; }
        public virtual ICollection<OfficePrinterPrefrence> OfficePrinterPrefrences { get; set; }
        public virtual ICollection<OfficeProductChangeHistory> OfficeProductChangeHistories { get; set; }
        public virtual ICollection<OutOfEscrowDeposit> OutOfEscrowDepositSourceTypeCds { get; set; }
        public virtual ICollection<OutOfEscrowDeposit> OutOfEscrowDepositStatusTypeCds { get; set; }
        public virtual ICollection<OutOfEscrowDeposit> OutOfEscrowDepositTransactionTypeCds { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositLink> OverDraftInEscrowDepositLinks { get; set; }
        public virtual ICollection<OverDraftMaster> OverDraftMasterCauseLossTypeCds { get; set; }
        public virtual ICollection<OverDraftMaster> OverDraftMasterProcessTypeCds { get; set; }
        public virtual ICollection<OverDraftMaster> OverDraftMasterTypeLossTypeCds { get; set; }
        public virtual ICollection<OverdraftDisbursement> OverdraftDisbursementCauseLossTypeCds { get; set; }
        public virtual ICollection<OverdraftDisbursement> OverdraftDisbursementProcessTypeCds { get; set; }
        public virtual ICollection<OverdraftDisbursement> OverdraftDisbursementTypeLossTypeCds { get; set; }
        public virtual ICollection<PaidDisbursement> PaidDisbursements { get; set; }
        public virtual ICollection<PaidStatusLog> PaidStatusLogs { get; set; }
        public virtual ICollection<PartnerLog> PartnerLogs { get; set; }
        public virtual ICollection<Payment> PaymentCardTypeCds { get; set; }
        public virtual ICollection<Payment> PaymentPaymentMethodTypeCds { get; set; }
        public virtual ICollection<Payment> PaymentTransactionTypeCds { get; set; }
        public virtual ICollection<PersonBpchangeHistory> PersonBpchangeHistories { get; set; }
        public virtual ICollection<PersonRoleRelationshipXref> PersonRoleRelationshipXrefs { get; set; }
        public virtual ICollection<PersonWebCustomerXref> PersonWebCustomerXrefs { get; set; }
        public virtual ICollection<PhraseElement> PhraseElementAlignmentTypeCds { get; set; }
        public virtual ICollection<PhraseElement> PhraseElementElementSeparatorTypeCds { get; set; }
        public virtual ICollection<PhraseElement> PhraseElementFormatTypeCds { get; set; }
        public virtual ICollection<PhraseElement> PhraseElementPictureTypeCds { get; set; }
        public virtual ICollection<PhraseElement> PhraseElementPrintCaseTypeCds { get; set; }
        public virtual ICollection<PhraseGrp> PhraseGrps { get; set; }
        public virtual ICollection<PreferredBusOrgContactXref> PreferredBusOrgContactXrefs { get; set; }
        public virtual ICollection<PreferredEmployeeContactXref> PreferredEmployeeContactXrefs { get; set; }
        public virtual ICollection<PreferredPersonXref> PreferredPersonXrefs { get; set; }
        public virtual ICollection<PrincipalAddInfo> PrincipalAddInfoLangPrefTypeCds { get; set; }
        public virtual ICollection<PrincipalAddInfo> PrincipalAddInfoSpouseLangPrefTypeCds { get; set; }
        public virtual ICollection<PrincipalBusEntity> PrincipalBusEntities { get; set; }
        public virtual ICollection<Principal> PrincipalOrgTypeCds { get; set; }
        public virtual ICollection<PrincipalSignature> PrincipalSignatures { get; set; }
        public virtual ICollection<Principal> PrincipalSms1099classificationCds { get; set; }
        public virtual ICollection<Principal> PrincipalSpouse1099ClassificationCds { get; set; }
        public virtual ICollection<Principal> PrincipalTypeCds { get; set; }
        public virtual ICollection<Principal> PrincipalVestingMaritalStatusTypeCds { get; set; }
        public virtual ICollection<Principal> PrincipalVestingTypeCds { get; set; }
        public virtual ICollection<ProcessTemplateWebCustomerXref> ProcessTemplateWebCustomerXrefs { get; set; }
        public virtual ICollection<ProcessTypeRoleTypeMap> ProcessTypeRoleTypeMapProcessTypeCds { get; set; }
        public virtual ICollection<ProcessTypeRoleTypeMap> ProcessTypeRoleTypeMapRoleTypeCds { get; set; }
        public virtual ICollection<ProductTypeBusUnitXref> ProductTypeBusUnitXrefs { get; set; }
        public virtual ICollection<ProfileChangeHistory> ProfileChangeHistories { get; set; }
        public virtual ICollection<ProgramTypeGeographicXref> ProgramTypeGeographicXrefs { get; set; }
        public virtual ICollection<ProgramTypeProductTypeXref> ProgramTypeProductTypeXrefs { get; set; }
        public virtual ICollection<ProgramTypeSearchInstruction> ProgramTypeSearchInstructions { get; set; }
        public virtual ICollection<ProgramTypeTransTypeXref> ProgramTypeTransTypeXrefs { get; set; }
        public virtual ICollection<ProjectFileSalePriceLiabilityXref> ProjectFileSalePriceLiabilityXrefs { get; set; }
        public virtual ICollection<Qcstaging> QcstagingMismotypeCds { get; set; }
        public virtual ICollection<Qcstaging> QcstagingQcstatusCds { get; set; }
        public virtual ICollection<QcstagingSectionXref> QcstagingSectionXrefs { get; set; }
        public virtual ICollection<RealProperty> RealPropertyEstateTypeCds { get; set; }
        public virtual ICollection<RealProperty> RealPropertyPropertyTypeCds { get; set; }
        public virtual ICollection<RecordedDocDetail> RecordedDocDetails { get; set; }
        public virtual ICollection<RecordingInfo> RecordingInfos { get; set; }
        public virtual ICollection<RegionIdforApplication> RegionIdforApplications { get; set; }
        public virtual ICollection<RoleChangeHistory> RoleChangeHistories { get; set; }
        public virtual ICollection<Rtmaddress> RtmaddressCourierTypeNavigations { get; set; }
        public virtual ICollection<Rtmaddress> RtmaddressEmployeeRoleTypeCds { get; set; }
        public virtual ICollection<Rtmaddress> RtmaddressPackageTypeNavigations { get; set; }
        public virtual ICollection<Rtmaddress> RtmaddressPhysicalAddrTypeCds { get; set; }
        public virtual ICollection<Rtmdocument> Rtmdocuments { get; set; }
        public virtual ICollection<SalesRepHistory> SalesRepHistories { get; set; }
        public virtual ICollection<SearchTypeTypeCdXref> SearchTypeTypeCdXrefs { get; set; }
        public virtual ICollection<SecOffcGrpChangeHistory> SecOffcGrpChangeHistories { get; set; }
        public virtual ICollection<ServiceFileAttribute> ServiceFileAttributes { get; set; }
        public virtual ICollection<ServiceFile> ServiceFileBusSegTypeCds { get; set; }
        public virtual ICollection<ServiceFileEmployeeXref> ServiceFileEmployeeXrefs { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeeDefaultPaymentMethodTypeCds { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeeFeeToBucketNavigations { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeeFeeTypeCds { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeeFileFeeCategoryTypeCds { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeeFileTransactionTypeCds { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeeGeographicTypeCds { get; set; }
        public virtual ICollection<ServiceFileFeePaymentDetail> ServiceFileFeePaymentDetailChargePaidByTypeCds { get; set; }
        public virtual ICollection<ServiceFileFeePaymentDetail> ServiceFileFeePaymentDetailPaymentMethodTypeCds { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFeePaymentMethodTypeCds { get; set; }
        public virtual ICollection<ServiceFileNote> ServiceFileNotes { get; set; }
        public virtual ICollection<ServiceFileProductTypeXref> ServiceFileProductTypeXrefs { get; set; }
        public virtual ICollection<ServiceFileTagFileXref> ServiceFileTagFileXrefs { get; set; }
        public virtual ICollection<ServiceFile> ServiceFileTransTypeCds { get; set; }
        public virtual ICollection<SigningAddrXref> SigningAddrXrefs { get; set; }
        public virtual ICollection<SigningParty> SigningParties { get; set; }
        public virtual ICollection<SigningPartyElecAddrXref> SigningPartyElecAddrXrefs { get; set; }
        public virtual ICollection<Signing> SigningProposedTimeRangeTypeCds { get; set; }
        public virtual ICollection<Signing> SigningProposedTimeZoneTypeCds { get; set; }
        public virtual ICollection<Signing> SigningSigningLocTypeCds { get; set; }
        public virtual ICollection<Signing> SigningSigningMethodTypeCds { get; set; }
        public virtual ICollection<Signing> SigningSigningQualities { get; set; }
        public virtual ICollection<Signing> SigningStatusCdNavigations { get; set; }
        public virtual ICollection<SplitFee> SplitFees { get; set; }
        public virtual ICollection<StateBusSegMapping> StateBusSegMappingBusinessSegments { get; set; }
        public virtual ICollection<StateBusSegMapping> StateBusSegMappingTransactionTypes { get; set; }
        public virtual ICollection<SubordinationLenderDetail> SubordinationLenderDetails { get; set; }
        public virtual ICollection<TaskTemplateCustomerXref> TaskTemplateCustomerXrefs { get; set; }
        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
        public virtual ICollection<TaxExemption> TaxExemptions { get; set; }
        public virtual ICollection<TaxInstallment> TaxInstallments { get; set; }
        public virtual ICollection<TaxRateInfo> TaxRateInfoTaxBaseMethodTypeCds { get; set; }
        public virtual ICollection<TaxRateInfo> TaxRateInfoTaxRateTypeCds { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessPartyEntitySubTypeCds { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessPartyRoleTypeCds { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayouts { get; set; }
        public virtual ICollection<TemplateProductTypeXrefDocPrep> TemplateProductTypeXrefDocPreps { get; set; }
        public virtual ICollection<TemplateProductTypeXref> TemplateProductTypeXrefs { get; set; }
        public virtual ICollection<TitleEscrowInfoLiabilityXref> TitleEscrowInfoLiabilityXrefs { get; set; }
        public virtual ICollection<TitleEscrowInfoSalesPriceXref> TitleEscrowInfoSalesPriceXrefs { get; set; }
        public virtual ICollection<UserLoginHistory> UserLoginHistories { get; set; }
        public virtual ICollection<VendorInfo> VendorInfos { get; set; }
        public virtual ICollection<WireDisbursementDetail> WireDisbursementDetails { get; set; }
        public virtual ICollection<WireHistory> WireHistories { get; set; }
        public virtual ICollection<WorkFlowTemplateAdditionalRoleTypeXref> WorkFlowTemplateAdditionalRoleTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateApnxref> WorkFlowTemplateApnxrefs { get; set; }
        public virtual ICollection<WorkFlowTemplateChangeHistory> WorkFlowTemplateChangeHistories { get; set; }
        public virtual ICollection<WorkFlowTemplateOriginatorXref> WorkFlowTemplateOriginatorXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplate> WorkFlowTemplateProductTypeCds { get; set; }
        public virtual ICollection<WorkFlowTemplateProductTypeXref> WorkFlowTemplateProductTypeXrefs { get; set; }
        public virtual ICollection<WorkFlowTemplate> WorkFlowTemplateRoleTypeCds { get; set; }
        public virtual ICollection<WorkQueueMessage> WorkQueueMessages { get; set; }
        public virtual ICollection<WorkQueueType> WorkQueueTypes { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
