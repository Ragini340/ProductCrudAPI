using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Tax
    {
        public Tax()
        {
            InverseSuperTax = new HashSet<Tax>();
            TaxExemptions = new HashSet<TaxExemption>();
            TaxInstallments = new HashSet<TaxInstallment>();
            FileProcesses = new HashSet<FileProcess>();
        }

        public int TaxId { get; set; }
        public int ClassTypeId { get; set; }
        public int TaxTypeCdId { get; set; }
        public int? SuperTaxId { get; set; }
        public int PropertyId { get; set; }
        public string? TaxNum { get; set; }
        public string? TaxYr { get; set; }
        public string? TaxRateAreaNum { get; set; }
        public string? SupplementalTaxNum { get; set; }
        public string? MiscTaxNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public byte? UpdateImpoundChargeFlag { get; set; }
        public byte? UpdateProrationChargeFlag { get; set; }
        public byte? TaxDataChangedFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual RealProperty Property { get; set; } = null!;
        public virtual Tax? SuperTax { get; set; }
        public virtual ICollection<Tax> InverseSuperTax { get; set; }
        public virtual ICollection<TaxExemption> TaxExemptions { get; set; }
        public virtual ICollection<TaxInstallment> TaxInstallments { get; set; }

        public virtual ICollection<FileProcess> FileProcesses { get; set; }
    }
}
