using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class ListHeader
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public ItemModuleType Type { get; set; }
        public DomainType DomainType { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public DateTime CreatedDateTime { get; set; }


        // Relationships
        public List<ListLine> Lines { get; set; }
        public List<DimensionHeader> DimHeaders { get; set; }
        public List<UserTransaction> Trans { get; set; }
        public List<ListHeader> LinkListHeaders { get; set; }

        public Guid ModuleId { get; set; }
        public Guid ModuleUserId { get; set; }
        public Module Module { get; set; }

        public Guid? FilterRefId { get; set; }
        public Guid? FilterRefUserId { get; set; }
        public string? FilterRefName { get; set; }
        public Module? ModuleRef { get; set; }
        public ItemGroup? ItemGroupRef { get; set; }
        public DimensionHeader? DimHeaderRef { get; set; }

        public Guid? LinkListHeaderId { get; set; }
        public Guid? LinkListHeaderUserId { get; set; }
        public ListHeader? LinkListHeader { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
