using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class UserTransaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        public UserTransType TransType { get; set; }
        public ItemModuleListType RefType { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public Guid? TransLinkId { get; set; }
        public Guid? TransLinkUserId { get; set; }
        public Guid? TransLinkName { get; set; }
        public Item? Item { get; set; }
        public Module? Module { get; set; }
        public ListHeader? ListHeader { get; set; }
        public ListLine? ListLine { get; set; }
        public DimensionHeader? DimensionHeader { get; set; }
        public DimensionLine? DimensionLine { get; set; }
        public DimensionCombination? DimensionCombination { get; set; }
        public DimensionGroup? DimensionGroup { get; set; }
        public ItemGroup? ItemGroup { get; set; }
        public TextFormattingEntity? TextFormattingEntity { get; set; }
        public ListFormattingEntity? ListFormattingEntity { get; set; }
        public LinkedFormattingEntity? LinkedFormattingEntity { get; set; }
        public Network? Follower { get; set; }


        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
