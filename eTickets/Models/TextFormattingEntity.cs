using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class TextFormattingEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        public ListBlock listBlockType;
        public Scales scale;

        // Relationships
        public Guid? LinkId { get; set; }
        public Guid? LinkUserId { get; set; }
        public string? LinkName { get; set; }
        public string? LinkFieldName { get; set; }
        public Module? ModuleLink { get; set; }
        public ListHeader? LiastHeaderLink { get; set; }
        public DimensionHeader? DimHeaderLink { get; set; }
        public DimensionLine? DimLineLink { get; set; }
        public Item? ItemLink { get; set; }
        public ItemGroup? ItemGroupLink { get; set; }
        public DimensionGroup? DimGroupLink { get; set; }
    }
}
