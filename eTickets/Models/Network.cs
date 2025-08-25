using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class Network
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        public AccessType accessType { get; set; }

        // Relation
        public Guid UserRefId { get; set; }
        public User UserRef { get; set; }

        public Guid FollowerRefId { get; set; }
        public User FollowerRef { get; set; }
    }
}
