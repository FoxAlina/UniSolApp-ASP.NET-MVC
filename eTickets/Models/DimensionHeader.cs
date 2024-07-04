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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }
        public TableDetailsListType TableType { get; set; }
        public DimensionLineType PropertyType { get; set; }
        public DomainType DomainType { get; set; }

        // Relationships
        public List<DimensionLine> Lines { get; set; }
        public List<DimensionCombination> DimCombs { get; set; }
        public List<Module> Modules { get; set; }
        public List<DimensionHeader> LinkDimHeaders { get; set; }
        public List<ListHeader> ListHeaderRefs { get; set; }

        public Guid? DimGroupId { get; set; }
        public Guid? DimGroupUserId { get; set; }
        public DimensionGroup? DimensionGroup { get; set; }

        public Guid? LinkHeaderId { get; set; }
        public Guid? LinkHeaderUserId { get; set; }
        public DimensionHeader? LinkHeader { get; set; }

        public Guid? ListHeaderId { get; set; }
        public Guid? ListHeaderUserId { get; set; }
        public ListHeader? ListHeader { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
