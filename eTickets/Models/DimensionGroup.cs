using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class DimensionGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
        public DomainType DomainType { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public List<DimensionHeader> DimHeaders { get; set; }
        public List<LinkedFormattingEntity> LinkedFormattingEntities { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
