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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

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

        public List<LinkedFormattingEntity> LinkedFormattingEntities { get; set; }

        public Guid? ModuleRefId { get; set; }
        public Guid? ModuleRefUserId { get; set; }
        public Module? ModuleRef { get; set; }

        public Guid? LinkModuleId { get; set; }
        public Guid? LinkModuleUserId { get; set; }
        public Module? LinkModule { get; set; }

        public Guid? FilterLinkId { get; set; }
        public Guid? FilterLinkUserId { get; set; }
        public Guid? FilterLinkName { get; set; }
        public ItemGroup? ItemGroup { get; set; }
        public DimensionHeader? DimHeader { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
