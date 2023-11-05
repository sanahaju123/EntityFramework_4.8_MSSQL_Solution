
using ContactManagementApp.Models;
using System.Data.Entity;


namespace ContactManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Contact> Contacts { get; set; }
    }
}