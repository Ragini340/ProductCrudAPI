using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Application
    {
        public Application()
        {
            ApplSourceBusOrgInfos = new HashSet<ApplSourceBusOrgInfo>();
            CustomerOrderOrderOriginators = new HashSet<CustomerOrder>();
            CustomerOrderSecondSourceAppls = new HashSet<CustomerOrder>();
            CustomerOrderSourceAppls = new HashSet<CustomerOrder>();
            ExportInfos = new HashSet<ExportInfo>();
            ExternalBusinessUnitXrefs = new HashSet<ExternalBusinessUnitXref>();
            InterfaceDeliveryRequests = new HashSet<InterfaceDeliveryRequest>();
            InternalAuditLogs = new HashSet<InternalAuditLog>();
            PartnerLogs = new HashSet<PartnerLog>();
            Qcstagings = new HashSet<Qcstaging>();
            ServiceFiles = new HashSet<ServiceFile>();
            ServiceOperationApplicationXrefs = new HashSet<ServiceOperationApplicationXref>();
            ServiceUserAccountApplicationXrefs = new HashSet<ServiceUserAccountApplicationXref>();
            Signings = new HashSet<Signing>();
            SimulatorSffilterData = new HashSet<SimulatorSffilterDatum>();
            WorkFlowTemplateApplicationXrefs = new HashSet<WorkFlowTemplateApplicationXref>();
            BusinessUnits = new HashSet<BusinessUnit>();
            ChangeNotifications = new HashSet<ChangeNotification>();
        }

        public int ApplId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public string? ExternalQueueName { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public int? UserId { get; set; }
        public int? AlertTypeCdId { get; set; }
        public bool AutoDelivery { get; set; }
        public int? Rbsenabled { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee? User { get; set; }
        public virtual ICollection<ApplSourceBusOrgInfo> ApplSourceBusOrgInfos { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrderOrderOriginators { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrderSecondSourceAppls { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrderSourceAppls { get; set; }
        public virtual ICollection<ExportInfo> ExportInfos { get; set; }
        public virtual ICollection<ExternalBusinessUnitXref> ExternalBusinessUnitXrefs { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequests { get; set; }
        public virtual ICollection<InternalAuditLog> InternalAuditLogs { get; set; }
        public virtual ICollection<PartnerLog> PartnerLogs { get; set; }
        public virtual ICollection<Qcstaging> Qcstagings { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
        public virtual ICollection<ServiceOperationApplicationXref> ServiceOperationApplicationXrefs { get; set; }
        public virtual ICollection<ServiceUserAccountApplicationXref> ServiceUserAccountApplicationXrefs { get; set; }
        public virtual ICollection<Signing> Signings { get; set; }
        public virtual ICollection<SimulatorSffilterDatum> SimulatorSffilterData { get; set; }
        public virtual ICollection<WorkFlowTemplateApplicationXref> WorkFlowTemplateApplicationXrefs { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
        public virtual ICollection<ChangeNotification> ChangeNotifications { get; set; }
    }
}
