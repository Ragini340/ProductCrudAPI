using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateInfoXrefInsert
    {
        public int TemplateId { get; set; }
        public byte? NotificationCandidateFlg { get; set; }
        public short UnderConstFlg { get; set; }
        public int? NextTemplateVersionId { get; set; }
        public int BusinessUnitId { get; set; }
        public int DocTypeCdId { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public string ObjectCd { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public short? PhraseExists { get; set; }
        public short ReadyToTestFlag { get; set; }
    }
}
