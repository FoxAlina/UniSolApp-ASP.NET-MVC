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
        [Key, MaxLength(20)]
        public string Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public List<Item> Items { get; set; }
        public List<Module> Modules { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

    }
}
