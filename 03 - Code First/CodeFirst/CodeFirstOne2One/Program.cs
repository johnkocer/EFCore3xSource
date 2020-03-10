using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartIT.DebugHelper;

namespace CodeFirstOne2One
{
  class Program
  {
    static void Main(string[] args)
    {
      string connection = @"Server=(localdb)\mssqllocaldb;Database=EmployeeEfCodeFirstOne2OneDB;Trusted_Connection=True;";

      DbContextOptions<DataContext> options = new DbContextOptionsBuilder<DataContext>()
           .UseSqlServer(connection)
           .Options;

      DataContext context = new DataContext(options);
      context.Database.EnsureDeleted();
      context.Database.EnsureCreated();

      if (!context.Employee.Any())
      {
        // Seed the database with employees
        context.Employee.Add(new Employee() { FirstName = "John", LastName = "Kocer" });
        context.Employee.Add(new Employee() { FirstName = "Adam", LastName = "Lee" });
        context.Employee.Add(new Employee() { FirstName = "Jon", LastName = "Walker" });
        context.Employee.Add(new Employee() { FirstName = "Jen", LastName = "Walker" });
        context.SaveChanges();
      }

      var employees = context.Employee.ToList();
    }
  }
}
