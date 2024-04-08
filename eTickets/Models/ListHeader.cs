using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class ListHeader
    {
        [Key]
        public string Id { get; set; }
        public string ProfilePictureURL { set; get; }
        public ItemModuleType Type { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public List<ListLine> Lines { get; set; }

        public string ModuleId { get; set; }
        [ForeignKey("ModuleId")]
        public Module Module { get; set; }
        public string ModuleRefId { get; set; }
        [ForeignKey("ModuleRefId")]
        public Module ModuleRef { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
