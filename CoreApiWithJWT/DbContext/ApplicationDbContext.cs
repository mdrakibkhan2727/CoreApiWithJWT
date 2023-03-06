using CoreApiWithJWT.IdentityAuth;
using CoreApiWithJWT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace CoreApiWithJWT.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }


        private static void  SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                  new IdentityRole() { Name="Admin",ConcurrencyStamp = "1",NormalizedName="Admin"},
                  new IdentityRole() { Name="User",ConcurrencyStamp = "2",NormalizedName="User"},
                  new IdentityRole() { Name="HR",ConcurrencyStamp = "3",NormalizedName="HR"}
                );
        }
    }
}
