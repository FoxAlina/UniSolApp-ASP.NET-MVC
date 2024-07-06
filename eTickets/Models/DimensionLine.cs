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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LotId { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }
        public DimensionLineType Type { get; set; }
        public int? Integer { get; set; }
        public double? Double { get; set; }
        public bool? Bool { get; set; }
        public string? String { get; set; }
        public ProgressStatus? Status { get; set; }
        public string? URL { get; set; }
        public DateTime? DateTime { get; set; }

        // Relationships
        public List<LinkedFormattingEntity> LinkedFormattingEntities { get; set; }

        public Guid DimensionHeaderId { get; set; }
        public Guid DimHeaderUserId { get; set; }
        public DimensionHeader DimensionHeader { get; set; }

        public Guid? ItemId { get; set; }
        public Guid? ItemUserId { get; set; }
        public Item? Item { get; set; }
    }
}
