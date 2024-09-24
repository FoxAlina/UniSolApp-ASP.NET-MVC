using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class ListFormattingEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        public ListBlock listBlockType;
        public Scales scale;

        public DateTime CreatedDateTime { get; set; }

        // Relationships
        public List<LinkedFormattingEntity> LinkedFormattingEntities { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
