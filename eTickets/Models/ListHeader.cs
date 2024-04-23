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
        [MaxLength(20)]
        public string Id { get; set; }
        public ItemModuleType Type { get; set; }
        public DomainType DomainType { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public DateTime CreatedDateTime { get; set; }


        // Relationships
        public List<ListLine> Lines { get; set; }
        public List<DimensionHeader> DimHeaders { get; set; }
        public List<UserTransaction> Trans { get; set; }
        public List<ListHeader> LinkListHeaders { get; set; }

        public string ModuleId { get; set; }
        public string ModuleUserId { get; set; }
        public Module Module { get; set; }

        public string? ModuleRefId { get; set; }
        public string? ModuleRefUserId { get; set; }
        public Module? ModuleRef { get; set; }

        public string? ItemGroupRefId { get; set; }
        public string? ItemGroupRefUserId { get; set; }
        public ItemGroup? ItemGroupRef { get; set; }

        public string? DimHeaderRefId { get; set; }
        public string? DimHeaderRefUserId { get; set; }
        public DimensionHeader? DimHeaderRef { get; set; }

        public string? LinkListHeaderId { get; set; }
        public string? LinkListHeaderUserId { get; set; }
        public ListHeader? LinkListHeader { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

    }
}
