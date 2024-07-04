using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class Follower
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        // Relation
        public Guid UserRefId { get; set; }
        public User UserRef { get; set; }

        public Guid FollowerRefId { get; set; }
        public User FollowerRef { get; set; }
    }
}
