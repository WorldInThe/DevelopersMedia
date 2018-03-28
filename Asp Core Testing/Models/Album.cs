﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models
{
    public class Album
    {
        public int Id { get; set; }
        public IList<Images> Images { get; set; }
        public DateTime? DateAdded { get; set; }
        public int ModelId { get; set; }

    }
    
}
