using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Testing.Models.ViewModels
{
    public class PostView
    {
        public ApplicationUser CurrentUser { get; set; }
        public UserModel User { get; set; }
        public List<Posts> Posts { get; set; }



    }
}
