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
        public string LotId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public string ListHeaderId { get; set; }
        [ForeignKey("ListHeaderId")]
        public ListHeader ListHeader { get; set; }

        public string ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
