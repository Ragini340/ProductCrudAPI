using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PrintPreference
    {
        public int PrintPreferencesId { get; set; }
        public string LoginName { get; set; } = null!;
        public string? UserPreferenceXml { get; set; }
        public string? ChequePreferenceXml { get; set; }
        public string? LocalPrinterXml { get; set; }
        public bool? MigrationStatus { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
