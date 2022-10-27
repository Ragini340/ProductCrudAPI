using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileStarterRefXref
    {
        public int FileId { get; set; }
        public int InheritFromFileId { get; set; }
        public byte? CopyAll { get; set; }
        public byte? CopyDocs { get; set; }
        public byte? Settlement { get; set; }
        public byte? Bsource { get; set; }
        public byte? PropTaxLegal { get; set; }
        public byte? Buyer { get; set; }
        public byte? Seller { get; set; }
        public byte? ConvertBs { get; set; }
        public byte? FileNotes { get; set; }
        public DateTime? CopyDate { get; set; }
        public byte? Product { get; set; }
        public int ServiceFileStarterRefXrefId { get; set; }
        public byte? TitleProdcution { get; set; }
    }
}
