using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class Item
    {
        [Key]
        public string Id { get; set; }

        public string ProfilePictureURL { set; get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships

        public string ItemGroupId { get; set; }
        [ForeignKey("ItemGroupId")]
        public ItemGroup ItemGroup { get; set; }
        
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public string ModuleId { get; set; }
        [ForeignKey("ModuleId")]
        public Module Module { get; set; }

    }
}
