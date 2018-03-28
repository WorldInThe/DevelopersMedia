using System;
using System.Collections.Generic;

namespace Asp_Core_Testing.Models
{
    public class Code_Snippets
    {
        public int Id { get; set; }

        public string CodeSnippet { get; set; }
        public IList<CodeComments> CodeComments { get; set; }
        public DateTime? DateAdded { get; set; }
        public int ModelId { get; set; }

    }

    public class CodeComments
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public string Poster { get; set; }
        public string PosterId { get; set; }
        public DateTime? DateAdded { get; set; }
        public int ModelId { get; set; }
    }
}