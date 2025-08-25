using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class DimensionCombination
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        // Relationships
        public List<DimensionLine> Lines { get; set; }

        public Guid ItemId { get; set; }
        public Guid ItemUserId { get; set; }
        public Item Item { get; set; }

        public Guid DimHeaderId { get; set; }
        public Guid DimHeaderUserId { get; set; }
        public DimensionHeader DimHeader{ get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
