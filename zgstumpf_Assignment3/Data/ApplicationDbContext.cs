using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using zgstumpf_Assignment3.Models;

namespace zgstumpf_Assignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<zgstumpf_Assignment3.Models.Movie> Movie { get; set; }
        public DbSet<zgstumpf_Assignment3.Models.Actor> Actor { get; set; }
        public DbSet<zgstumpf_Assignment3.Models.MovieActor> MovieActor { get; set; }
    }
}