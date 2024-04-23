using UniversalSolutionApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class Item
    {
        [MaxLength(20)]
        public string Id { get; set; }

        public string? ProfilePictureURL { set; get; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DomainType DomainType { get; set; }
        public ItemStatus ItemStatus { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public List<DimensionCombination> DimCombs { get; set; }
        public List<DimensionLine> DimLines { get; set; }
        public List<ListLine> ListLines { get; set; }
        public List<UserTransaction> Trans { get; set; }
        public List<Item> LinkItems { get; set; }

        public string? LinkItemId { get; set; }
        public string? LinkItemUserId { get; set; }
        public Item? LinkItem { get; set; }

        public string ItemGroupId { get; set; }
        public string ItemGroupUserId { get; set; }
        public ItemGroup ItemGroup { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public string? ModuleId { get; set; }
        public string? ModuleUserId { get; set; }
        public Module? Module { get; set; }

    }
}
