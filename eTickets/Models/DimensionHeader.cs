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
        [Key, MaxLength(20)]
        public string Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public TableDetailsListType TableType { get; set; }
        public DimensionLineType PropertyType { get; set; }

        // Relationships
        public List<DimensionLine> Lines { get; set; }
        public List<DimensionCombination> DimCombs { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

    }
}
