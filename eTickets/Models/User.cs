using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class User
    {
        [Key, MaxLength(20)]
        public string Id { set; get; }

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
        public List<ListHeader> ListHeaders { get; set; }
        public List<Module> Modules { get; set; }
        public List<Item> Items { get; set; }
        public List<Follower> Followers { get; set; }
        public List<Follower> UserRefs { get; set; }
        public List<UserTransaction> Trans { get; set; }
    }
}
