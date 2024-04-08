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
        [Key]
        public string Id { get; set; }
        public UserTransType TransType { get; set; }
        public ItemModuleListType RefType { get; set; }

        // Relationships
        public string ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public string ModuleId { get; set; }
        [ForeignKey("ModuleId")]
        public Module Module { get; set; }
        public string ListId { get; set; }
        [ForeignKey("ListId")]
        public ListHeader List { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
