using Microsoft.EntityFrameworkCore;

namespace AgGrid.Models
{
    public class ContextClass : DbContext
    {
        public ContextClass(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> products { get; set; }
    }
}
