using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string PosterId { get; set; }
        public string Poster { get; set; }
        public string Comment { get; set; }
        public DateTime? DateAdded { get; set; }
        public int ModelId { get; set; }

    }
}
