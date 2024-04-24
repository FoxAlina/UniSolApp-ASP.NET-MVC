using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class ItemGroup
    {
        [MaxLength(20)]
        public string Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DomainType DomainType { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public List<Item> Items { get; set; }
        public List<Module> Modules { get; set; }
        public List<ItemGroup> LinkItemGroups { get; set; }

        public List<ListHeader> ListHeaderRefs { get; set; }

        public string? LinkItemGroupId { get; set; }
        public string? LinkItemGroupUserId { get; set; }
        public ItemGroup? LinkItemGroup { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

    }
}
