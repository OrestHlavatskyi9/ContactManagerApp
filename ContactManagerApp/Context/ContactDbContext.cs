using Microsoft.EntityFrameworkCore;
using ContactManagerApp.Models;

namespace ContactManagerApp.Context
{
    public class ContactDbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, Name = "Orest", Email = null, Phone = "+380995643521" }
            );
        }
    }
}
