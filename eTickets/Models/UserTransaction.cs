using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Data.Enums;

namespace UniversalSolutionApplication.Models
{
    public class UserTransaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }
        public UserTransType TransType { get; set; }
        public ItemModuleListType RefType { get; set; }

        // Relationships
        public Guid TransLinkUserId { get; set; }
        public Guid TransLinkId { get; set; }
        public Guid TransLinkName { get; set; }
        public Item? Item { get; set; }
        public Module? Module { get; set; }
        public ListHeader? List { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
