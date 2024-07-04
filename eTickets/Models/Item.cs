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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        public string? ProfilePictureURL { set; get; }
        [MaxLength(100)]
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

        public Guid? LinkItemId { get; set; }
        public Guid? LinkItemUserId { get; set; }
        public Item? LinkItem { get; set; }

        public Guid ItemGroupId { get; set; }
        public Guid ItemGroupUserId { get; set; }
        public ItemGroup ItemGroup { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid? ModuleId { get; set; }
        public Guid? ModuleUserId { get; set; }
        public Module? Module { get; set; }

    }
}
