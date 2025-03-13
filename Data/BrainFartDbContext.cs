using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BrainFart.Models;

namespace BrainFart.Data
{
    public class BrainFartDbContext : IdentityDbContext
    {
        public BrainFartDbContext(DbContextOptions<BrainFartDbContext> options)
    : base(options) { }

        public DbSet<Whiteboard> Whiteboards { get; set; }
    }
}
