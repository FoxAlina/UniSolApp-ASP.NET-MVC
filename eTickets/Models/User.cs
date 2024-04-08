using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Models
{
    public class User
    {
        [Key]
        public string Id { set; get; }

        public string ProfilePictureURL { set; get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NickName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
