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

        public string? ProfilePictureURL { set; get; }
        [Display(Name = "Name")]
        [MaxLength(30, ErrorMessage = "Maximum length is 30 simbols.")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        public bool General { get; set; }
        [Display(Name = "Status")]
        public ItemStatus ItemStatus { get; set; }
        [Display(Name = "Privacy")]
        public DomainType DomainType { get; set; }
        [Display(Name = "Created date")]
        public DateTime CreatedDateTime { get; set; }


        // Relationships
        public List<Item>? Items { get; set; }
        public List<UserTransaction>? Trans { get; set; }
        public List<Module>? ModuleRefs { get; set; }

        public List<ListHeader>? ListHeaders { get; set; }
        public List<ListHeader>? ListHeaderRefs { get; set; }

        public List<LinkedFormattingEntity>? LinkedFormattingEntities { get; set; }

        public Guid? ModuleRefId { get; set; }
        public Guid? ModuleRefUserId { get; set; }
        public Module? ModuleRef { get; set; }

        public Guid? FilterLinkId { get; set; }
        public Guid? FilterLinkUserId { get; set; }
        public Guid? FilterLinkName { get; set; }
        public ItemGroup? ItemGroup { get; set; }
        public DimensionHeader? DimHeader { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public void init()
        {
            this.Id = Guid.NewGuid();
            this.CreatedDateTime = DateTime.UtcNow;
            this.DomainType = DomainType.Private;
            this.ItemStatus = ItemStatus.Open;
            this.General = true;

            //To do: this.UserId = GetUserById
        }
    }
}
