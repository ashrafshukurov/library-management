using Microsoft.EntityFrameworkCore;
using library_management.Models;

namespace library_management.Data
{
    public class ApiContext : DbContext

    {
        public DbSet<Book> Books { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

    }
}
