using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class CodeProjects
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public IList<Code_Snippets> CodeSnippets { get; set; }
        public DateTime? DateAdded { get; set; }
        public int ModelId { get; set; }
    }
}
