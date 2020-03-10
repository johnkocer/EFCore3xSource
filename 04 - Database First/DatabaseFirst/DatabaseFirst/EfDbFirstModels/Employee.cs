﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst.EfDbFirstModels
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
