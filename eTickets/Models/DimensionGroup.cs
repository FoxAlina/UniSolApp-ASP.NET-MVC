using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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

        // Relationships

        public List<DimensionHeader> DimHeaders { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
