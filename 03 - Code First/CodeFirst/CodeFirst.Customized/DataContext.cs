using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Customized
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }
  }
}
