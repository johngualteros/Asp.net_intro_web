using Microsoft.EntityFrameworkCore;
using Asp.net_intro_web.Models;
namespace Asp.net_intro_web.Data
{
    public class AspNetContext : DbContext
    {
        public AspNetContext(DbContextOptions<AspNetContext> options) : base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().ToTable("Quote");
        }
    }
}
