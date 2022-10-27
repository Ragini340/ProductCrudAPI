using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseHistory
    {
        public int PhraseHistoryId { get; set; }
        public int PhraseId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int UserId { get; set; }
        public int StatusCd { get; set; }
        public string? Comments { get; set; }

        public virtual Phrase Phrase { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
