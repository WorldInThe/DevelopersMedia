using Asp_Core_Testing.Data;
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
        public ICollection<Album> Album { get; set; }
        public ICollection<Posts> Posts { get; set; }
        public bool IsPrivate { get; set; }
        public ICollection<CodeProjects> CodeProjects { get; set; }

        public string getName(string User)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var UList = db.User.ToList().Find(x => x.Email.Contains(User));
            string name = UList.Name;
            return name;
        }

    }
}
