using Microsoft.EntityFrameworkCore;
namespace ContactAPI.data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}