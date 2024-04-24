using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class Module
    {
        [MaxLength(20)]
        public string Id { set; get; }

        public string? ProfilePictureURL { set; get; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool General { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public DomainType DomainType { get; set; }


        // Relationships
        public List<Item> Items { get; set; }
        public List<UserTransaction> Trans { get; set; }
        public List<Module> LinkModules { get; set; }
        public List<Module> ModuleRefs { get; set; }

        public List<ListHeader> ListHeaders { get; set; }
        public List<ListHeader> ListHeaderRefs { get; set; }

        public string? ModuleRefId { get; set; }
        public string? ModuleRefUserId { get; set; }
        public Module? ModuleRef { get; set; }

        public string? LinkModuleId { get; set; }
        public string? LinkModuleUserId { get; set; }
        public Module? LinkModule { get; set; }

        public string? ItemGroupId { get; set; }
        public string? ItemGroupUserId { get; set; }
        public ItemGroup? ItemGroup { get; set; }

        public string? DimHeaderId { get; set; }
        public string? DimHeaderUserId { get; set; }
        public DimensionHeader? DimHeader { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
