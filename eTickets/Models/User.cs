using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { set; get; }

        [MaxLength(20)]
        public string SurrogateId { get; set; }

        public string? ProfilePictureURL { set; get; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(20)]
        public string NickName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //relations
        public List<ItemGroup> ItemGroups { get; set; }
        public List<DimensionHeader> DimensionHeaders { get; set; }
        public List<DimensionGroup> DimensionGroups { get; set; }
        public List<ListHeader> ListHeaders { get; set; }
        public List<Module> Modules { get; set; }
        public List<Item> Items { get; set; }
        public List<Follower> Followers { get; set; }
        public List<Follower> UserRefs { get; set; }
        public List<UserTransaction> Trans { get; set; }
        public List<LinkedFormattingEntity> LinkedFormattingEntity { get; set; }
        public List<ListFormattingEntity> ListFormattingEntity { get; set; }
        public List<TextFormattingEntity> TextFormattingEntity { get; set; }
    }
}
