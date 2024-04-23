using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class Follower
    {
        [MaxLength(20)]
        public string Id { set; get; }

        // Relation

        public string UserId { get; set; }
        public User User { get; set; }
        public string FollowerRefId { get; set; }
        public User FollowerRef { get; set; }
    }
}
