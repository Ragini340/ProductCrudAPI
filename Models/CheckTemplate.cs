using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CheckTemplate
    {
        public int CheckTemplateId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public string LatexBodyFileName { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
    }
}
