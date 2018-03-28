using Asp_Core_Testing.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Programming Languages")]
        public string ProgLanguages { get; set; }
        [Required]
        public string Specializations { get; set; }
        [DisplayName("Profile Picture")]
        public string AvatarURL { get; set; }
        public IList<Album> Album { get; set; }
        public IList<Posts> Posts { get; set; }
        public IList<Following> Following { get; set; }
        public bool IsPrivate { get; set; }
        public IList<CodeProjects> CodeProjects { get; set; }

        public string GetName(string User)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var UList = db.User.ToList().Find(x => x.Email.Contains(User));
            string name = UList.Name;
            return name;
        }

    }

    public class Following
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int UserId { get; set; }
    }
}
