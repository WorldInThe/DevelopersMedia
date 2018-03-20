using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class Images
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime DateAdded { get; set; }

    }
    public enum Category
    {
        Code,
        Memes
    }
}
