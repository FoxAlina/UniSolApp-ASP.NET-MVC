using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class LinkedFormattingEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        public FormattingType FormattingType { get; set; }
        public string FilterLinkName { get; set; }

        // Relations
        public Guid? ModuleId { get; set; }
        public Guid? ModuleUserId { get; set; }
        public Module? Module { get; set; }

        public Guid? ListHeaderId { get; set; }
        public Guid? ListHeaderUserId { get; set; }
        public ListHeader? ListHeader { get; set; }

        public Guid? DimensionHeaderId { get; set; }
        public Guid? DimensionHeaderUserId { get; set; }
        public DimensionHeader? DimensionHeader { get; set; }

        public Guid? DimensionLineId { get; set; }
        public Guid? DimensionLineUserId { get; set; }
        public DimensionLine? DimensionLine { get; set; }

        public Guid? ItemId { get; set; }
        public Guid? ItemUserId { get; set; }
        public Item? Item { get; set; }
        
        public Guid? ItemGroupId { get; set; }
        public Guid? ItemGroupUserId { get; set; }
        public ItemGroup? ItemGroup { get; set; }

        public Guid? DimensionGroupId { get; set; }
        public Guid? DimensionGroupUserId { get; set; }
        public DimensionGroup? DimensionGroup { get; set; }

        public Guid? TextFormattingEntityId { get; set; }
        public Guid? TextFormattingEntityUserId { get; set; }
        public TextFormattingEntity? TextFormattingEntity { get; set; }

        public Guid? ListFormattingEntityId { get; set; }
        public Guid? ListFormattingEntityUserId { get; set; }
        public ListFormattingEntity? ListFormattingEntity { get; set; }


        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
