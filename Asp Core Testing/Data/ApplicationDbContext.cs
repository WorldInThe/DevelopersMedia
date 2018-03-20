using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Asp_Core_Testing.Models;

namespace Asp_Core_Testing.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<UserModel> User { get; set; }

        public DbSet<Album> Album { get; set; }
        public DbSet<Images> Images { get; set; }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }

        public DbSet<CodeProjects> CodeProjects { get; set; }
        public DbSet<CodeComments> CodeComments { get; set; }
        public DbSet<Code_Snippets> Code_Snippets { get; set; }




        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
