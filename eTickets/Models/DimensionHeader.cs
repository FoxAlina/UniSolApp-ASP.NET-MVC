using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class DimensionHeader
    {
        [Key]
        public string Id { get; set; }
        public TableDetailsListType Type { get; set; }

        // Relationships
        public List<DimensionLine> Lines { get; set; }

        public string ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
