using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class DimensionLine
    {
        
        public float LineNum { get; set; }
        public string LotId { get; set; }

        public string Name { get; set; }
        public DimensionLineType Type { get; set; }
        public int Integer { get; set; }
        public double Double { get; set; }
        public bool Bool { get; set; }
        public string String { get; set; }
        public ProgressStatus Status { get; set; }
        public string URL { get; set; }
        public DateTime DateTime { get; set; }

        // Relationships
        //public List<Module> Modules { get; set; }

        public string DimHeaderId { get; set; }
        [ForeignKey("DimensionHeaderId")]
        public DimensionHeader DimensionHeader { get; set; }

        public string ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
