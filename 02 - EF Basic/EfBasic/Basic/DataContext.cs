using Microsoft.EntityFrameworkCore;

namespace Basic
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Blog> Blog { get; set; }
  }

}
