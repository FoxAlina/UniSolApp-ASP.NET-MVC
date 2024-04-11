using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class Module
    {
        [Key, MaxLength(20)]
        public string Id { set; get; }

        public string? ProfilePictureURL { set; get; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool General { get; set; }

        // Relationships
        public List<Item> Items { get; set; }

        public string? ModuleRefId { get; set; }
        [ForeignKey("ModuleRefId")]
        public Module? ModuleRef { get; set; }

        public string? ItemGroupId { get; set; }
        public ItemGroup? ItemGroup { get; set; }

        public string? DimHeaderId { get; set; }
        [ForeignKey("DimHeaderId")]
        public DimensionHeader? DimHeader { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
