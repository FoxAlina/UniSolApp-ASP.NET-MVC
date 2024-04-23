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
        [MaxLength(20)]
        public string Id { get; set; }

        // Relationships

        public string ItemId { get; set; }
        public string ItemUserId { get; set; }
        public Item Item { get; set; }

        public string DimHeaderId { get; set; }
        public string DimHeaderUserId { get; set; }
        public DimensionHeader DimHeader{ get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
