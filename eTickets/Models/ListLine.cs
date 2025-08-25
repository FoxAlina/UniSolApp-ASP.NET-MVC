using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class ListLine
    {
        public float LineNum { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LotId { set; get; }

        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public Guid ListHeaderId { get; set; }
        public Guid ListHeaderUserId { get; set; }
        public ListHeader ListHeader { get; set; }

        public Guid ItemId { get; set; }
        public Guid ItemUserId { get; set; }
        public Item Item { get; set; }
    }
}
