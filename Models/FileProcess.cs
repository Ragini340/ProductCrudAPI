using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileProcess
    {
        public FileProcess()
        {
            Charges = new HashSet<Charge>();
            CoInsurancePolicies = new HashSet<CoInsurancePolicy>();
            Disbursements = new HashSet<Disbursement>();
            Ibatransactions = new HashSet<Ibatransaction>();
            InverseSuperFileProcess = new HashSet<FileProcess>();
            ProjectFileSiteFileProcessXrefPffileProcesses = new HashSet<ProjectFileSiteFileProcessXref>();
            ProjectFileSiteFileProcessXrefSffileProcesses = new HashSet<ProjectFileSiteFileProcessXref>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            Taxes = new HashSet<Tax>();
        }

        public int FileProcessId { get; set; }
        public int? SuperFileProcessId { get; set; }
        public int ClassTypeId { get; set; }
        public int ProcessTypeCdId { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int FileId { get; set; }
        public short? SeqNum { get; set; }
        public short? FileProcessStatusFlag { get; set; }
        public string? Comments { get; set; }
        public int UpdatedEmployeeId { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? SplitLspgrpFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual FileBusinessParty? FileBusinessParty { get; set; }
        public virtual TypeCdDmt ProcessTypeCd { get; set; } = null!;
        public virtual FileProcess? SuperFileProcess { get; set; }
        public virtual Employee UpdatedEmployee { get; set; } = null!;
        public virtual AssociationInfo? AssociationInfo { get; set; }
        public virtual AttorneyInfo? AttorneyInfo { get; set; }
        public virtual FbpsearchVendorInfo? FbpsearchVendorInfo { get; set; }
        public virtual FctloanInfo? FctloanInfo { get; set; }
        public virtual HoldFundInfo? HoldFundInfo { get; set; }
        public virtual HomeWarrantyInfo? HomeWarrantyInfo { get; set; }
        public virtual InspReprInfo? InspReprInfo { get; set; }
        public virtual InsuranceInfo? InsuranceInfo { get; set; }
        public virtual LeaseInfo? LeaseInfo { get; set; }
        public virtual LoanInfo? LoanInfo { get; set; }
        public virtual QcclosingInfo? QcclosingInfo { get; set; }
        public virtual RebrokerInfo? RebrokerInfo { get; set; }
        public virtual SurveyInfo? SurveyInfo { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual ICollection<CoInsurancePolicy> CoInsurancePolicies { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<Ibatransaction> Ibatransactions { get; set; }
        public virtual ICollection<FileProcess> InverseSuperFileProcess { get; set; }
        public virtual ICollection<ProjectFileSiteFileProcessXref> ProjectFileSiteFileProcessXrefPffileProcesses { get; set; }
        public virtual ICollection<ProjectFileSiteFileProcessXref> ProjectFileSiteFileProcessXrefSffileProcesses { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }

        public virtual ICollection<Tax> Taxes { get; set; }
    }
}
