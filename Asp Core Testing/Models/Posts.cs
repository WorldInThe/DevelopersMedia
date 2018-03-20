using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class Posts
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public List<Comments> Comments { get; set; }
        public PostType PostType { get; set; }
        public DateTime DateAdded { get; set; }


    }
    public enum PostType
    {
        Image,
        Code,
        Status,
        Update
    }
}
