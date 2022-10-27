using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileBusinessParty
    {
        public FileBusinessParty()
        {
            AssociationInfos = new HashSet<AssociationInfo>();
            Charges = new HashSet<Charge>();
            ClosingDisclosureTransactionData = new HashSet<ClosingDisclosureTransactionDatum>();
            Disbursements = new HashSet<Disbursement>();
            EditFileBusinessPartyContacts = new HashSet<EditFileBusinessPartyContact>();
            FbpserviceTypeXrefs = new HashSet<FbpserviceTypeXref>();
            FileBusinessPartyConsumerMessageBoxDetails = new HashSet<FileBusinessPartyConsumerMessageBoxDetail>();
            FileBusinessPartyLicenseInformationXrefs = new HashSet<FileBusinessPartyLicenseInformationXref>();
            FileProcesses = new HashSet<FileProcess>();
            IbabankAccounts = new HashSet<IbabankAccount>();
            InsuranceInfos = new HashSet<InsuranceInfo>();
            InterOfficeFees = new HashSet<InterOfficeFee>();
            InverseSuperFileBusinessParty = new HashSet<FileBusinessParty>();
            Loan1LoanInvestorContacts = new HashSet<Loan1LoanInvestorContact>();
            Loan1LoanInvestors = new HashSet<Loan1LoanInvestor>();
            LoanInfoLenderPayeeParents = new HashSet<LoanInfo>();
            LoanInfoMortgageBrokers = new HashSet<LoanInfo>();
            LoanInfoTrustees = new HashSet<LoanInfo>();
            OverDraftDisbursementFbpxrefs = new HashSet<OverDraftDisbursementFbpxref>();
            OverDraftFbpxrefs = new HashSet<OverDraftFbpxref>();
            ProjectFileSiteFileFbpxrefPffileBusinessParties = new HashSet<ProjectFileSiteFileFbpxref>();
            RebrokerInfos = new HashSet<RebrokerInfo>();
            Rtmaddresses = new HashSet<Rtmaddress>();
            ServiceFees = new HashSet<ServiceFee>();
            ServiceFileDeliveryInstructions = new HashSet<ServiceFileDeliveryInstruction>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            SigningParties = new HashSet<SigningParty>();
            SplitFeeFeeOwnerFbps = new HashSet<SplitFee>();
            SplitFeeFeeSplitFbps = new HashSet<SplitFee>();
            SubordinationLenderDetails = new HashSet<SubordinationLenderDetail>();
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
        }

        public int FileBusinessPartyId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int RoleTypeCdId { get; set; }
        public int? SuperFileBusinessPartyId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? BusOrgId { get; set; }
        public int? PrincipalId { get; set; }
        public int? ContactId { get; set; }
        public string? AttentionName { get; set; }
        public string? RefNum { get; set; }
        public short IssueCheckFlag { get; set; }
        public int? CheckDescriptionDetailId { get; set; }
        public int? EntitySubTypeCdId { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? Sales1EmployeeId { get; set; }
        public int? Sales2EmployeeId { get; set; }
        public int? TitleAgentTypeCdId { get; set; }
        public short? StatusEmailFlag { get; set; }
        public int? DisableNotificationCdId { get; set; }
        public int? BusOrgAlternateNameId { get; set; }
        public int? GabrequestBusOrgReferenceId { get; set; }
        public int? PhysicalAddrId { get; set; }
        public int? PersonId { get; set; }
        public int? RefBusOrgId { get; set; }
        public int? RefContactId { get; set; }
        public int? AgentOfficeId { get; set; }

        public virtual BusinessUnit? AgentOffice { get; set; }
        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusOrgAlternateName? BusOrgAlternateName { get; set; }
        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual CheckDescriptionDetail? CheckDescriptionDetail { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual BusOrgContact? Contact { get; set; }
        public virtual TypeCdDmt? DisableNotificationCd { get; set; }
        public virtual TypeCdDmt? EntitySubTypeCd { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual GabrequestBusOrgReference? GabrequestBusOrgReference { get; set; }
        public virtual Person? Person { get; set; }
        public virtual PhysicalAddr? PhysicalAddr { get; set; }
        public virtual Principal? Principal { get; set; }
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
        public virtual Employee? Sales1Employee { get; set; }
        public virtual Employee? Sales2Employee { get; set; }
        public virtual FileBusinessParty? SuperFileBusinessParty { get; set; }
        public virtual TypeCdDmt? TitleAgentTypeCd { get; set; }
        public virtual DipstatusFbpxref? DipstatusFbpxref { get; set; }
        public virtual FileBusinessPartyContactXref? FileBusinessPartyContactXref { get; set; }
        public virtual ProjectFileSiteFileFbpxref? ProjectFileSiteFileFbpxrefSffileBusinessParty { get; set; }
        public virtual TaxpayerXref? TaxpayerXref { get; set; }
        public virtual ICollection<AssociationInfo> AssociationInfos { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual ICollection<ClosingDisclosureTransactionDatum> ClosingDisclosureTransactionData { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<EditFileBusinessPartyContact> EditFileBusinessPartyContacts { get; set; }
        public virtual ICollection<FbpserviceTypeXref> FbpserviceTypeXrefs { get; set; }
        public virtual ICollection<FileBusinessPartyConsumerMessageBoxDetail> FileBusinessPartyConsumerMessageBoxDetails { get; set; }
        public virtual ICollection<FileBusinessPartyLicenseInformationXref> FileBusinessPartyLicenseInformationXrefs { get; set; }
        public virtual ICollection<FileProcess> FileProcesses { get; set; }
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<InsuranceInfo> InsuranceInfos { get; set; }
        public virtual ICollection<InterOfficeFee> InterOfficeFees { get; set; }
        public virtual ICollection<FileBusinessParty> InverseSuperFileBusinessParty { get; set; }
        public virtual ICollection<Loan1LoanInvestorContact> Loan1LoanInvestorContacts { get; set; }
        public virtual ICollection<Loan1LoanInvestor> Loan1LoanInvestors { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoLenderPayeeParents { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoMortgageBrokers { get; set; }
        public virtual ICollection<LoanInfo> LoanInfoTrustees { get; set; }
        public virtual ICollection<OverDraftDisbursementFbpxref> OverDraftDisbursementFbpxrefs { get; set; }
        public virtual ICollection<OverDraftFbpxref> OverDraftFbpxrefs { get; set; }
        public virtual ICollection<ProjectFileSiteFileFbpxref> ProjectFileSiteFileFbpxrefPffileBusinessParties { get; set; }
        public virtual ICollection<RebrokerInfo> RebrokerInfos { get; set; }
        public virtual ICollection<Rtmaddress> Rtmaddresses { get; set; }
        public virtual ICollection<ServiceFee> ServiceFees { get; set; }
        public virtual ICollection<ServiceFileDeliveryInstruction> ServiceFileDeliveryInstructions { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
        public virtual ICollection<SigningParty> SigningParties { get; set; }
        public virtual ICollection<SplitFee> SplitFeeFeeOwnerFbps { get; set; }
        public virtual ICollection<SplitFee> SplitFeeFeeSplitFbps { get; set; }
        public virtual ICollection<SubordinationLenderDetail> SubordinationLenderDetails { get; set; }
        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
    }
}
