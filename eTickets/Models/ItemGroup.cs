using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class ItemGroup
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
