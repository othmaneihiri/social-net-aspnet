using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PhonebookMVC.Models
{
    public class UpfbookMvcDB : DbContext
    {
        public UpfbookMvcDB() : base("UpfbookMvcDB")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Publication> Publications { get; set; }

        public DbSet<Content> Contents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}