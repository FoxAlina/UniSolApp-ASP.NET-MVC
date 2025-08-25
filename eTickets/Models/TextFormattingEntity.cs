using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class TextFormattingEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        public ListBlock listBlockType;
        public Scales scale;

        // Relationships
        public List<LinkedFormattingEntity> LinkedFormattingEntities { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
