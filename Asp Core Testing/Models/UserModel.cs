using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        [DisplayName("Programming Languages")]
        public string ProgLanguages { get; set; }
        public string Specializations { get; set; }
        [DisplayName("Profile Picture")]
        public string AvatarURL { get; set; }
        public List<Album> Album { get; set; }
        public List<Posts> Posts { get; set; }
        public bool IsPrivate { get; set; }
        public List<CodeProjects> CodeProjects { get; set; }

    }
}
