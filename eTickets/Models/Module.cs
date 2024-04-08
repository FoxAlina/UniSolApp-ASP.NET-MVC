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
        [Key]
        public string Id { set; get; }

        public string ProfilePictureURL { set; get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool General { get; set; }

        // Relationships
        public string ModuleRefId { get; set; }
        [ForeignKey("ModuleRefId")]
        public Module ModuleRef { get; set; }

        public string ItemGroupId { get; set; }
        [ForeignKey("ItemGroupId")]
        public ItemGroup ItemGroup { get; set; }

        //public string LotId { get; set; }
        //[ForeignKey("LotId")]
        //public DimensionLine DimLine { get; set; }
    }
}
