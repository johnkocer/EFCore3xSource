using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
  public class Employee
  {
    public int EmployeeId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    [NotMapped]
    public string FullName { get { return FirstName + " " + LastName; } }
  }

  public class Department
  {
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
  }
}
