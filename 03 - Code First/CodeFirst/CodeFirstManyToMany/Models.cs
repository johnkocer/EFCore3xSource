using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstManyToMany
{
  public class Employee
  {
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [NotMapped]
    public string FullName { get { return FirstName + " " + LastName; } }
    public virtual List<EmployeeProject> EmployeeProject { get; set; }
  }

  public class Project
  {
    [Key]
    public int ProjectId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public virtual List<EmployeeProject> EmployeeProject { get; set; }
  }

  public class EmployeeProject
  {
    public int ProjectId { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public Project Project { get; set; }
  }
}
