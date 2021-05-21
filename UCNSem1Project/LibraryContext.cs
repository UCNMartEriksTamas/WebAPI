
using Microsoft.EntityFrameworkCore;
using UCNSem1Project.Models;

namespace UCNSem1Project
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Loan> Loans { get; set; }
        //public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>().ToTable("Loan");
        }

    }
}