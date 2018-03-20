using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class CodeProjects
    {
        public int Id { get; set; }
        public List<Code_Snippets> CodeSnippets { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
